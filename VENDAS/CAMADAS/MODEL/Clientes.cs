using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VENDAS.CAMADAS.MODEL
{
    public class Clientes
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string celular { get; set; }
        public string municipio { get; set; }
        public string endereco { get; set; }
        public string cep { get; set; }
    }
}
