using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading;
using System.Windows.Forms;

namespace AppBuscaCep
{
    public partial class TelaRetorno : Form
    {
        Thread t1;

        public TelaRetorno(HttpResponseMessage retornoApi)
        {
            InitializeComponent();

            ApresentarDados(retornoApi);
        }

        public async void ApresentarDados(HttpResponseMessage retornoApi)
        {
            try
            {
                string conteudoApi = await retornoApi.Content.ReadAsStringAsync();

                dynamic obj = JsonConvert.DeserializeObject(conteudoApi);

                PreencherTabela(obj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados da API: " + ex.Message);
            }
        }

        public  void PreencherTabela(dynamic obj)
        {
            CampoCepRetorno.Text = obj.cep;
            CampoLog.Text = obj.logradouro;
            CampoComplemento.Text = obj.complemento;
            CampoBairro.Text = obj.bairro;
            CampoCidade.Text = obj.localidade;
            CampoUf.Text = obj.uf;
            CampoEstado.Text = obj.estado;
            CampoRegiao.Text = obj.regiao;
            CampoDDD.Text = obj.ddd;
        }

        private void BotaoNovaConsulta_Click(object sender, EventArgs e)
        {
            if (true)
            {
                this.Close();
                t1 = new Thread(abrirJanela);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
        }

        private void abrirJanela()
        {
            Application.Run(new TelaPrincipal());
        }

    }
}
