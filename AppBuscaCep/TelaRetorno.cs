using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBuscaCep
{
    public partial class TelaRetorno : Form
    {
        Thread t1;

        public TelaRetorno()
        {
            InitializeComponent();
        }

        private void TelaRetorno_Load(object sender, EventArgs e)
        {
            
        }

        private void TelaRetorno_FormClosed(object sender, FormClosedEventArgs e)
        {
            
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
