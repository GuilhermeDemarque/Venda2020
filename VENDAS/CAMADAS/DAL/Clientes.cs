using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VENDAS.CAMADAS.DAL
{
    public class Clientes
    {
        private string strCon = Conexao.getConexao();
        public List<MODEL.Clientes> Select()
        {
            
            List<MODEL.Clientes> lstClientes = new List<MODEL.Clientes>();
            SqlConnection conexao = new SqlConnection(strCon);

            string sql = "Select * from Clientes";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Clientes cliente = new MODEL.Clientes();
                    cliente.codigo = Convert.ToInt32(dados[0].ToString());
                    cliente.nome = dados["nome"].ToString();
                    cliente.cpf = dados["cpf"].ToString();
                    cliente.celular = dados["celular"].ToString();
                    cliente.municipio = dados["municipio"].ToString();
                    cliente.endereco = dados["endereco"].ToString();
                    cliente.cep = dados["cep"].ToString();

                    lstClientes.Add(cliente);

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

            return lstClientes;

        }
        public void Insert(MODEL.Clientes cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Clientes values (@nome, @cpf, @celular, @municipio,@endereco , @cep);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@cpf", cliente.cpf);
            cmd.Parameters.AddWithValue("@celular", cliente.celular);
            cmd.Parameters.AddWithValue("@municipio", cliente.municipio);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@cep", cliente.cep);

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
        public void Update(MODEL.Clientes cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Clientes SET nome=@nome, cpf=@cpf, celular=@celular, municipio=@municipio , endereco=@endereco, cep=@cep  ";
            sql += " WHERE codigo=@codigo;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigo", cliente.codigo);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@cpf", cliente.cpf);
            cmd.Parameters.AddWithValue("@celular", cliente.celular);
            cmd.Parameters.AddWithValue("@municipio", cliente.municipio);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@cep", cliente.cep);

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

        public void Delete(int idCliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Clientes  WHERE codigo=@codigo;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@codigo", idCliente);

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
