using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VENDAS.CAMADAS.BLL
{
    class Compra
    {
        public List<MODEL.Compra> Select()
        {
            DAL.Compra dalCom = new DAL.Compra();
            return dalCom.Select();
        }

        public void Insert(MODEL.Compra compra)
        {
            DAL.Compra dalCom = new DAL.Compra();
            dalCom.Insert(compra);
        }
        public void Update(MODEL.Compra compra)
        {
            DAL.Compra dalCom = new DAL.Compra();
            dalCom.Update(compra);
        }
        public void Delete(int idCompra)
        {
            DAL.Compra dalCom = new DAL.Compra();
            dalCom.Delete(idCompra);
        }
    }
}
