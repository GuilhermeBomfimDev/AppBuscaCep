using AppBuscaCep.Model;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading;
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
            if (true)
            {
                if (CampoBuscaCep.Text.Length == 5 || CampoBuscaCep.Text.Length == 9)
                {
                    string url = $"https://viacep.com.br/ws/{CampoBuscaCep.Text}/json/";

                    try
                    {
                        HttpResponseMessage response = await client.GetAsync(url);

                        if (response.IsSuccessStatusCode)
                        {
                            ErroCepInvalido.Hide();
                            ErroCepNull.Hide();
                            ErroCepNaoEncontrado.Hide();

                            this.Close();

                            t1 = new Thread(() => abrirJanela(response));
                            t1.SetApartmentState(ApartmentState.STA);
                            t1.Start();
                        }
                        else
                        {
                            ErroCepNaoEncontrado.Show();
                            ErroCepInvalido.Hide();
                            ErroCepNull.Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao buscar o CEP: " + ex.Message);
                    }
                }
                else if (CampoBuscaCep.Text == null || CampoBuscaCep.Text.Length == 0)
                {
                    ErroCepInvalido.Hide();
                    ErroCepNaoEncontrado.Hide();

                    ErroCepNull.Show();
                    return;
                }
                else if (CampoBuscaCep.Text.Length != 5 || CampoBuscaCep.Text.Length != 8)
                {
                    ErroCepNull.Hide();
                    ErroCepNaoEncontrado.Hide();

                    ErroCepInvalido.Show();
                    return;
                }
            }
        }

        private void abrirJanela(HttpResponseMessage retornoApi)
        {
            Application.Run(new TelaRetorno(retornoApi));
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
