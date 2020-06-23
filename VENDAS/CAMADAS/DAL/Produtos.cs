using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace VENDAS.CAMADAS.DAL
{
    public class Produtos
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Produtos> Select()
        {

            List<MODEL.Produtos> lstProdutos = new List<MODEL.Produtos>();
            SqlConnection conexao = new SqlConnection(strCon);

            string sql = "Select * from Produtos";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Produtos produto= new MODEL.Produtos();
                    produto.codproduto = Convert.ToInt32(dados[0].ToString());
                    produto.nomeproduto = dados["nomeproduto"].ToString();
                    produto.quantidade = Convert.ToInt32(dados["quantidade"].ToString());
                    produto.precocusto = Convert.ToSingle(dados["precocusto"].ToString());
                    produto.precovenda = Convert.ToSingle(dados["precovenda"].ToString());


                    lstProdutos.Add(produto);

                }
            }
            catch
            {

                Console.WriteLine("Erro no comando select de Produto");
            }
            finally
            {
                conexao.Close();
            }

            return lstProdutos;

        }

        public List<MODEL.Produtos> SelectByCodigo( int codproduto)
        {

            List<MODEL.Produtos> lstProdutos = new List<MODEL.Produtos>();
            SqlConnection conexao = new SqlConnection(strCon);

            string sql = "Select * from Produtos WHERE codproduto=@codproduto;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codproduto", codproduto);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Produtos produto = new MODEL.Produtos();
                    produto.codproduto = Convert.ToInt32(dados[0].ToString());
                    produto.nomeproduto = dados["nomeproduto"].ToString();
                    produto.quantidade = Convert.ToInt32(dados["quantidade"].ToString());
                    produto.precocusto = Convert.ToSingle(dados["precocusto"].ToString());
                    produto.precovenda = Convert.ToSingle(dados["precovenda"].ToString());


                    lstProdutos.Add(produto);

                }
            }
            catch
            {

                Console.WriteLine("Erro no comando select de Produto");
            }
            finally
            {
                conexao.Close();
            }

            return lstProdutos;

        }

        public List<MODEL.Produtos> SelectByNome( string nomeproduto)
        {

            List<MODEL.Produtos> lstProdutos = new List<MODEL.Produtos>();
            SqlConnection conexao = new SqlConnection(strCon);

            string sql = "Select * from Produtos WHERE (nomeproduto LIKE @nomeproduto) ; ";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nomeproduto", "%" + nomeproduto + "%");
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Produtos produto = new MODEL.Produtos();
                    produto.codproduto = Convert.ToInt32(dados[0].ToString());
                    produto.nomeproduto = dados["nomeproduto"].ToString();
                    produto.quantidade = Convert.ToInt32(dados["quantidade"].ToString());
                    produto.precocusto = Convert.ToSingle(dados["precocusto"].ToString());
                    produto.precovenda = Convert.ToSingle(dados["precovenda"].ToString());


                    lstProdutos.Add(produto);

                }
            }
            catch
            {

                Console.WriteLine("Erro no comando select de Produto");
            }
            finally
            {
                conexao.Close();
            }

            return lstProdutos;

        }
        public void Insert(MODEL.Produtos produtos)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Produtos VALUES (@nomeproduto, @quantidade, @precocusto, @precovenda  );";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nomeproduto", produtos.nomeproduto);
            cmd.Parameters.AddWithValue("@quantidade", produtos.quantidade);
            cmd.Parameters.AddWithValue("@precocusto", produtos.precocusto);
            cmd.Parameters.AddWithValue("@precovenda", produtos.precovenda);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro sql inserir Produtos...");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Produtos produtos)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Produtos SET nomeproduto=@nomeproduto, quantidade=@quantidade, precocusto=@precocusto, precovenda=@precovenda   ";
            sql += "WHERE codproduto=@codproduto;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codproduto", produtos.codproduto);
            cmd.Parameters.AddWithValue("@nomeproduto", produtos.nomeproduto);
            cmd.Parameters.AddWithValue("@quantidade", produtos.quantidade);
            cmd.Parameters.AddWithValue("@precocusto", produtos.precocusto);
            cmd.Parameters.AddWithValue("@precovenda", produtos.precovenda);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro sql atualizar Produtos...");
            }
            finally
            {
                conexao.Close();
            }

        }

        public void Delete(int idProduto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Produtos WHERE codproduto=@codproduto;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codproduto", idProduto);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro sql Remover Produtos...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
