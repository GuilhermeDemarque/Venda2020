using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VENDAS.CAMADAS.BLL
{
    public class Fornecedor
    {
        public List<MODEL.Fornecedores> Select()
        {
            DAL.Fornecedores dalFor = new DAL.Fornecedores();
            return dalFor.Select();
        }

        public void Insert (MODEL.Fornecedores fornecedor)
        {
            DAL.Fornecedores dalFor = new DAL.Fornecedores();
            dalFor.Insert(fornecedor);
        }
        public void Update(MODEL.Fornecedores fornecedor)
        {
            DAL.Fornecedores dalFor = new DAL.Fornecedores();
            dalFor.Update(fornecedor);
        }
        public void Delete(int idFornecedor)
        {
            DAL.Fornecedores dalFor = new DAL.Fornecedores();
            dalFor.Delete(idFornecedor);
        }


    }
}
