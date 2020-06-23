using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VENDAS.CAMADAS.MODEL
{
    public class Produtos
    {
        public int codproduto { get; set; }
        public string nomeproduto { get; set; }
        public int quantidade { get; set; }
        public float precocusto { get; set; }
        public float precovenda { get; set; }
       
    }
}
