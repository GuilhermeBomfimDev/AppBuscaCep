using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBuscaCep.Model
{
    internal class RetornoApi
    {
        public string CEP { get; set; }
        public string Estado { get; set; }
        public decimal Cidade { get; set; }
        public string Distrito { get; set; }
        public string Endereco { get; set; }
    }
}
