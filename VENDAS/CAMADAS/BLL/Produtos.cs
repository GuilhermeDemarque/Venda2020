using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VENDAS.CAMADAS.BLL
{
    public class Produtos
    {
        public List<MODEL.Produtos> Select()
        {
            DAL.Produtos dalProdutos = new DAL.Produtos();
            return dalProdutos.Select();
        }
        public List<MODEL.Produtos> SelectByCodigo(int codproduto)
        {
            DAL.Produtos dalProdutos = new DAL.Produtos();
            return dalProdutos.SelectByCodigo(codproduto);
        }
        public List<MODEL.Produtos> SelectByNome(string nomeproduto)
        {
            DAL.Produtos dalProdutos = new DAL.Produtos();
            return dalProdutos.SelectByNome(nomeproduto);
        }

        public void Insert(MODEL.Produtos produto)
        {
            DAL.Produtos dalProdutos = new DAL.Produtos();
            dalProdutos.Insert(produto);
        }

        public void Update(MODEL.Produtos produto)
        {
            DAL.Produtos dalProdutos = new DAL.Produtos();
            dalProdutos.Update(produto);
        }

        public void Delete(int codproduto)
        {
            DAL.Produtos dalProdutos = new DAL.Produtos();
            dalProdutos.Delete(codproduto);
        }


    }
}
