using AppBuscaCep.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBuscaCep
{
    public partial class TelaPrincipal : Form
    {
        Thread t1;
        static HttpClient client = new HttpClient();

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if ((CampoBuscaCep.Text == null || CampoBuscaCep.Text.Length == 0) && (CampoBuscaEndereco.Text == null || CampoBuscaEndereco.Text.Length < 5))
            {
                ErroCepInvalido.Hide();
                ErroCepNaoEncontrado.Hide();

                ErroCampoNull.Show();
                return;
            }

            if (CampoBuscaCep.Text.Length != 0)
            {
                if (CampoBuscaCep.Text.Length == 5 || CampoBuscaCep.Text.Length == 8)
                {

                    string cepFormatado = CampoBuscaCep.Text.Insert(5, "-");
                    string url = $"https://viacep.com.br/ws/{cepFormatado}/json/";

                    try
                    {
                        HttpResponseMessage response = await client.GetAsync(url);

                        if (response.IsSuccessStatusCode)
                        {
                            ErroCepInvalido.Hide();
                            ErroCampoNull.Hide();
                            ErroCepNaoEncontrado.Hide();

                            this.Close();

                            t1 = new Thread(() => abrirJanelaCep(response));
                            t1.SetApartmentState(ApartmentState.STA);
                            t1.Start();
                        }
                        else
                        {
                            ErroCepNaoEncontrado.Show();
                            ErroCepInvalido.Hide();
                            ErroCampoNull.Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao buscar o CEP: " + ex.Message);
                    }
                }
                else if (CampoBuscaCep.Text.Length != 5 || CampoBuscaCep.Text.Length != 8)
                {
                    ErroCampoNull.Hide();
                    ErroCepNaoEncontrado.Hide();

                    ErroCepInvalido.Show();
                    return;
                }
            }
            else
            {
                MensagemLoad.Show();
                string respostaFinal = await MontarStringApi(CampoBuscaEndereco.Text);

                string url = respostaFinal;

                if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
                {
                    MessageBox.Show("URL inválida: " + url);
                    MensagemLoad.Hide();
                    return;
                }

                MessageBox.Show(url);

                try
                {
                    client.Timeout = TimeSpan.FromSeconds(10);
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();

                        List<CepDados> enderecos = JsonConvert.DeserializeObject<List<CepDados>>(json);

                        if (enderecos.Count > 0 || enderecos != null)
                        {
                            MensagemLoad.Hide();
                            ErroCepInvalido.Hide();
                            ErroCampoNull.Hide();
                            ErroCepNaoEncontrado.Hide();

                            this.Close();

                            t1 = new Thread(() => abrirJanelaEnderecos(enderecos));
                            t1.SetApartmentState(ApartmentState.STA);
                            t1.Start();
                        }
                        else
                        {
                            ErroCepNaoEncontrado.Show();
                            ErroCepInvalido.Hide();
                            ErroCampoNull.Hide();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar o endereço: " + ex.Message);
                }
            }
        }

        public async Task<string> MontarStringApi(string texto)
        {
            string promptBuscaIA =
                $"A partir da frase abaixo, extraia com exatidão os seguintes dados:" +
                $"\n- UF (sigla do estado com exatamente 2 letras, como SP, RJ, MG)" +
                $"\n- Nome da cidade (sem acentos ou abreviações)" +
                $"\n- Nome da rua (apenas o nome, sem tipo de logradouro como 'Rua', 'Av', 'Estrada', etc)" +

                $"\n\nExemplo correto: Se a frase for 'Avenida Paulista em São Paulo, SP', a resposta deve ser:" +
                $"\nhttps://viacep.com.br/ws/SP/Sao Paulo/Paulista/json/" +

                $"\n\n⚠️ Regras obrigatórias:" +
                $"\n1. NÃO inclua palavras como Rua, Avenida, Travessa, Rodovia, etc. na rua." +
                $"\n2. O nome da rua deve ser só o nome limpo, sem abreviações (ex: 'Paulista', não 'Av. Paulista')." +
                $"\n3. O nome da cidade deve estar no lugar certo (no segundo segmento da URL, após o UF)." +
                $"\n4. A resposta deve ser apenas a URL no formato exato: https://viacep.com.br/ws/UF/Cidade/Rua/json/" +
                $"\n5. NÃO adicione nada além da URL (sem comentários, sem explicações, sem texto antes ou depois)." +

                $"\n\nFrase: '{texto}'";



            using (HttpClient client = new HttpClient())
            {
                var endereco = new StringContent(
                    JsonConvert.SerializeObject(new { prompt = promptBuscaIA }),
                    Encoding.UTF8,
                    "application/json"
                );

                var resposta = await client.PostAsync("http://localhost:5000/pergunta", endereco);
                string jsonReposta = await resposta.Content.ReadAsStringAsync();

                JObject obj = JObject.Parse(jsonReposta);
                string respostaFinal = (string)obj["resposta"];

                return respostaFinal;
            }
        }
        private void abrirJanelaCep(HttpResponseMessage retornoApi)
        {
            Application.Run(new TelaRetorno(retornoApi));
        }

        private void abrirJanelaEnderecos(List<CepDados> enderecos)
        {
            Application.Run(new TelaListaEnderecos(enderecos));
        }

        private void CampoBuscaCep_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}
