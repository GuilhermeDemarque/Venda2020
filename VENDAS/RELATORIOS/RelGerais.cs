using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VENDAS.RELATORIOS
{
    public class RelGerais
    {

        public static void relClientes()
        {
        CAMADAS.BLL.Clientes bllClientes = new CAMADAS.BLL.Clientes();
        List<CAMADAS.MODEL.Clientes> lstClientes = new List<CAMADAS.MODEL.Clientes>();
            lstClientes = bllClientes.Select().OrderBy( o => o.nome).ToList();

            string pasta = Funcoes.deretorioPasta();
            string arquivo = pasta + @"\RelClientes.html";
            StreamWriter sw = new StreamWriter(arquivo);
            using (sw)
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv = 'Content-Type' " +
                            "content='text/html; charset=utf-8'/>");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css' integrity='sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh' crossorigin= 'anonymous'>");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<h1> Relatorio Clientes</h1>");
                sw.WriteLine("<hr align= 'left' border:'5px' />");
                sw.WriteLine("</br>");
                sw.WriteLine("<table class='table table-hover'>");
                sw.WriteLine("<tr>");
                sw.WriteLine("<th align='right' width='30px'>");
                sw.WriteLine("CODIGO");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='250px'>");
                sw.WriteLine("NOME");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='150px'>");
                sw.WriteLine("CPF");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='150px'>");
                sw.WriteLine("CELULAR");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='150px'>");
                sw.WriteLine("MUNICIPIO");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='150px'>");
                sw.WriteLine("ENDERECO");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='150px'>");
                sw.WriteLine("CEP");
                sw.WriteLine("</th>");
                sw.WriteLine("</tr>");
                int cont = 0;
                
                foreach (CAMADAS.MODEL.Clientes clientes in lstClientes)
                {
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td align='left' width='30px'>");
                    sw.WriteLine(clientes.codigo);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='left' width='250px'>");
                    sw.WriteLine(clientes.nome);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='left' width='150px'>");
                    sw.WriteLine(clientes.cpf);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='left' width='150px'>");
                    sw.WriteLine(clientes.celular);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='left' width='150px'>");
                    sw.WriteLine(clientes.municipio);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='left' width='150px'>");
                    sw.WriteLine(clientes.endereco);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='left' width='150px'>");
                    sw.WriteLine(clientes.cep);
                    sw.WriteLine("</td>");
                    sw.WriteLine("</tr>");
                    cont++;
                }
               

                sw.WriteLine("</table>");
                sw.WriteLine("<hr align= 'left' border:'5px' />");
                sw.WriteLine("<h2> Total De Clientes {0} Cadastrados" , cont);
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
            }

            System.Diagnostics.Process.Start(arquivo);
    }
        
    }
}
