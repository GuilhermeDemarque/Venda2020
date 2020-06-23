using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VENDAS.CAMADAS.DAL
{
    public class Itens
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Itens> Select()
        {

            List<MODEL.Itens> lstItens = new List<MODEL.Itens>();
            SqlConnection conexao = new SqlConnection(strCon);

            string sql = "Select * from Itens";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Itens item = new MODEL.Itens();
                    item.id = Convert.ToInt32(dados[0].ToString());
                    item.produtoid = Convert.ToInt32(dados["produtoid"].ToString());
                    item.produto = dados["produto"].ToString();



                    lstItens.Add(item);

                }
            }
            catch
            {

                Console.WriteLine("Erro no comando select de Venda");
            }
            finally
            {
                conexao.Close();
            }

            return lstItens;

        }
        public void Insert(MODEL.Itens item)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Itens VALUES ( @produtoid, @produto  );";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@produtoid", item.produtoid);
            cmd.Parameters.AddWithValue("@produto", item.produto);


            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro sql inserir Item...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Itens item)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Itens SET produtoid=@produtoid, produto=@produto   ";
            sql += "WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", item.id);
            cmd.Parameters.AddWithValue("@produtoid", item.produtoid);
            cmd.Parameters.AddWithValue("@produto", item.produto);


            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro sql atualizar Item...");
            }
            finally
            {
                conexao.Close();
            }

        }

        public void Delete(int idItens)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Itens WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idItens);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro sql Remover Item...");
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
