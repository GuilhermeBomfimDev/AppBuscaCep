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
                string conteudoApi = await retornoApi.Content.ReadAsStringAsync(); // Li o conteúdo do retorno da API

                dynamic obj = JsonConvert.DeserializeObject(conteudoApi); // Separar os itens de acordo com o retorno em JSON

                PreencherTabela(obj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados da API: " + ex.Message);
            }
        }

        public  void PreencherTabela(dynamic obj)
        {
            TabelaDados.Controls.Clear();


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
