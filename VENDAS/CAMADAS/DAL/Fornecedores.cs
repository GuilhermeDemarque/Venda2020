using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace VENDAS.CAMADAS.DAL
{
    public class Fornecedores
    {
        private string strCon = Conexao.getConexao();
        public List<MODEL.Fornecedores> Select()
        {

            List<MODEL.Fornecedores> lstFornecedores = new List<MODEL.Fornecedores>();
            SqlConnection conexao = new SqlConnection(strCon);

            string sql = "Select * from Fornecedores";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Fornecedores fornecedor = new MODEL.Fornecedores();
                    fornecedor.codigo = Convert.ToInt32(dados[0].ToString());
                    fornecedor.nome = dados["nome"].ToString();
                    fornecedor.cnpj = dados["cnpj"].ToString();
                    fornecedor.telefone = dados["telefone"].ToString();



                    lstFornecedores.Add(fornecedor);

                }
            }
            catch
            {

                Console.WriteLine("Erro no comando select de cliente");
            }
            finally
            {
                conexao.Close();
            }

            return lstFornecedores;
        }


            public void Insert(MODEL.Fornecedores fornecedor)
            {
                SqlConnection conexao = new SqlConnection(strCon);
                string sql = "INSERT INTO Fornecedores VALUES (@nome, @cnpj, @telefone);";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", fornecedor.nome);
                cmd.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);
                cmd.Parameters.AddWithValue("@telefone", fornecedor.telefone);
                

                try
                {
                    conexao.Open();
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    Console.WriteLine("erro inserção clientes");
                }
                finally
                {
                    conexao.Close();
                }
            }


        public void Update(MODEL.Fornecedores fornecedor)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Fornecedores SET nome=@nome, cnpj=@cnpj, telefone=@telefone    ";
            sql += " WHERE codigo=@codigo;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigo", fornecedor.codigo);
            cmd.Parameters.AddWithValue("@nome", fornecedor.nome);
            cmd.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);
            cmd.Parameters.AddWithValue("@telefone", fornecedor.telefone);
            

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("erro update de clientes ");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(int idFornecedor)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Fornecedores  WHERE codigo=@codigo;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigo", idFornecedor);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("erro remoção  de clientes...");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
    }

