using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace VENDAS.CAMADAS.DAL
{
    public class Compra
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Compra> Select()
        {

            List<MODEL.Compra> lstCompra = new List<MODEL.Compra>();
            SqlConnection conexao = new SqlConnection(strCon);

            string sql = "Select * from Compra";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Compra compra= new MODEL.Compra();
                    compra.codcompra = Convert.ToInt32(dados[0].ToString());
                    compra.codigo = Convert.ToInt32(dados["codigo"].ToString());
                    compra.fornecedor = dados["fornecedor"].ToString();
                    compra.nomeproduto= dados["nomeproduto"].ToString();



                    lstCompra.Add(compra);

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

            return lstCompra;

        }
        public void Insert(MODEL.Compra compra)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Compra VALUES ( @codigo, @fornecedor,@nomeproduto  );";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigo", compra.codigo);
            cmd.Parameters.AddWithValue("@fornecedor", compra.fornecedor);
            cmd.Parameters.AddWithValue("@nomeproduto", compra.nomeproduto);


            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro sql inserir Compra...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Compra compra)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Compra SET codigo=@codigo, fornecedor=@fornecedor , nomeproduto=@nomeproduto   ";
            sql += "WHERE codcompra=@codcompra;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codcompra", compra.codcompra);
            cmd.Parameters.AddWithValue("@codigo", compra.codigo);
            cmd.Parameters.AddWithValue("@fornecedor", compra.fornecedor);
            cmd.Parameters.AddWithValue("@nomproduto", compra.nomeproduto);


            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro sql atualizar Compra...");
            }
            finally
            {
                conexao.Close();
            }

        }

        public void Delete(int idCompra)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Compra WHERE codcompra=@codcompra;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codcompra", idCompra);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro sql Remover Compra...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
