using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VENDAS.CAMADAS.BLL
{
    public class Clientes
    {
        public List<MODEL.Clientes> Select()
        {
            DAL.Clientes dalCli = new DAL.Clientes();
            return dalCli.Select();
        }

        public void Insert(MODEL.Clientes clientes)
        {
            DAL.Clientes dalCli = new DAL.Clientes();
            dalCli.Insert(clientes);
        }
        public void Update(MODEL.Clientes clientes)
        {
            DAL.Clientes dalCli = new DAL.Clientes();
            dalCli.Update(clientes);
        }
        public void Delete(int idClientes)
        {
            DAL.Clientes dalCli = new DAL.Clientes();
            dalCli.Delete(idClientes);
        }

    }
}
