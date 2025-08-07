using AppBuscaCep.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBuscaCep
{
    public partial class TelaListaEnderecos : Form
    {
        private List<CepDados> _enderecos;
        private object listBox1;

        public TelaListaEnderecos(List<CepDados> enderecos)
        {
            InitializeComponent();
            _enderecos = enderecos;
            
            listView1.Columns.Add("CEP", 100);
            listView1.Columns.Add("Logradouro", 180);
            listView1.Columns.Add("Complemento", 120);
            listView1.Columns.Add("Bairro", 120);
            listView1.Columns.Add("UF", 40);
            listView1.Columns.Add("Estado", 150);
            listView1.Columns.Add("Região", 100);
            listView1.Columns.Add("DDD", 40);

            foreach (var item in enderecos)
            {
                ListViewItem linha = new ListViewItem(item.cep);
                linha.SubItems.Add(item.logradouro);
                linha.SubItems.Add(item.complemento);
                linha.SubItems.Add(item.bairro);
                linha.SubItems.Add(item.uf);
                linha.SubItems.Add(item.estado);
                linha.SubItems.Add(item.regiao);
                linha.SubItems.Add(item.ddd);

                listView1.Items.Add(linha);
            }

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (i % 2 == 0)
                    listView1.Items[i].BackColor = Color.WhiteSmoke;
                else
                    listView1.Items[i].BackColor = Color.LightGray;
            }
        }
    }
}
