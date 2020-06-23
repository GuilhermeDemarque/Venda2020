using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace VENDAS.RELATORIOS
{
    public class RelProdutos
    {
        public static void relProdutos() { 

        CAMADAS.BLL.Produtos bllProdutos = new CAMADAS.BLL.Produtos();
        List<CAMADAS.MODEL.Produtos> lstProdutos = new List<CAMADAS.MODEL.Produtos>();
            lstProdutos = bllProdutos.Select();

        string pasta = Funcoes.deretorioPasta();
        string arquivo = pasta + @"\RelProdutos.html";
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
                sw.WriteLine("<h1> Relatorio Produtos</h1>");
                sw.WriteLine("<hr align= 'left' border:'5px' />");
                sw.WriteLine("</br>");
                sw.WriteLine("<table class='table table-hover'>");
                sw.WriteLine("<tr>");
                sw.WriteLine("<th align='right' width='30px'>");
                sw.WriteLine("CODIGO");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='250px'>");
                sw.WriteLine("NOME PRODUTO");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='150px'>");
                sw.WriteLine("QUANTIDADE");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='150px'>");
                sw.WriteLine("PRECO CUSTO");
                sw.WriteLine("</th>");
                sw.WriteLine("<th align='right' width='150px'>");
                sw.WriteLine("PRECO VENDA");
                sw.WriteLine("</th>");
                
                sw.WriteLine("</tr>");
                int cont = 0;
                float total = 0;
                float total2 = 0;
                foreach (CAMADAS.MODEL.Produtos produtos in lstProdutos)
                {
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td align='left' width='30px'>");
                    sw.WriteLine(produtos.codproduto);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='left' width='250px'>");
                    sw.WriteLine(produtos.nomeproduto);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='left' width='150px'>");
                    sw.WriteLine(produtos.quantidade);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='left' width='150px'>");
                    sw.WriteLine(produtos.precocusto);
                    sw.WriteLine("</td>");
                    sw.WriteLine("<td align='left' width='150px'>");
                    sw.WriteLine(produtos.precovenda);
                    sw.WriteLine("</td>");
                    
                    sw.WriteLine("</tr>");
                    total = total + produtos.precocusto;
                    total2 = total2 + produtos.precovenda;
                    cont++;
                }


                sw.WriteLine("</table>");
                sw.WriteLine("<hr align= 'left' border:'5px' />");
                sw.WriteLine("<h2> Total De Produtos {0} Cadastrados" , cont);
                sw.WriteLine("<h2>Valor Dos Produtos de Preco De Custo  : " + string.Format("{0:R$ #,#.00}", total));
                sw.WriteLine("<h2>Valor Dos Produtos de Preco De Venda : " + string.Format("{0:R$ #,#.00}", total2));
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
            }

            System.Diagnostics.Process.Start(arquivo);
    }
        
    }
    }

