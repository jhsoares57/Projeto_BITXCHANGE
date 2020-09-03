using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using BIT_ACESSABANCO;

namespace BLL
{
    public class Usuario
    {
        public ConnectionFactory cf = new ConnectionFactory();

        public void cadastrarUsuario(string nome, string email, string senha, string cpf, string sexo)
        {
            try
            {
                string query = "INSERT INTO TB_USUARIO " +
                "(USU_STR_NOME, USU_STR_EMAIL, USU_STR_SENHA, USU_STR_CPF, USU_STR_SEXO) " +
                "VALUES (NOME, EMAIL, SENHA, CPF, SEXO)";
                cf.Comando = cf.Conexao.CreateCommand();
                cf.Comando.Parameters.AddWithValue("USU_STR_NOME", nome);
                cf.Comando.Parameters.AddWithValue("USU_STR_EMAIL", email);
                cf.Comando.Parameters.AddWithValue("USU_STR_SENHA", senha);
                cf.Comando.Parameters.AddWithValue("USU_STR_CPF", cpf);
                cf.Comando.Parameters.AddWithValue("USU_STR_SEXO", sexo);
                cf.Comando.CommandType = CommandType.Text;
                cf.Comando.CommandText = query.ToString();
                cf.Conexao.Open();
                SqlCommand sqlCommand = new SqlCommand(query, cf.Conexao);
                cf.Conexao.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void alterarUsuario(string nome, string email, string senha, string cpf, string sexo)
        {
            try
            {
                string query = "UPDATE TB_USUARIO SET " +
                "USU_STR_NOME = NOME, USU_STR_EMAIL = EMAIL, USU_STR_SENHA = SENHA," +
                "USU_STR_SEXO = SEXO" +
                "WHERE USU_STR_CPF = CPF";
                cf.Comando = cf.Conexao.CreateCommand();
                cf.Comando.Parameters.AddWithValue("USU_STR_NOME", nome);
                cf.Comando.Parameters.AddWithValue("USU_STR_EMAIL", email);
                cf.Comando.Parameters.AddWithValue("USU_STR_SENHA", senha);
                cf.Comando.Parameters.AddWithValue("USU_STR_CPF", cpf);
                cf.Comando.Parameters.AddWithValue("USU_STR_SEXO", sexo);
                cf.Comando.CommandType = CommandType.Text;
                cf.Comando.CommandText = query.ToString();
                cf.Conexao.Open();
                SqlCommand sqlCommand = new SqlCommand(query, cf.Conexao);
                cf.Conexao.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DbDataReader selecionaUsuario(string cpf)
        {
            try
            {
                string query = "SELECT * FROM TB_USUARIO WHERE USU_STR_CPF = CPF";
                cf.Comando = cf.Conexao.CreateCommand();
                cf.Comando.Parameters.AddWithValue("USU_STR_CPF", cpf);
                cf.Comando.CommandType = CommandType.Text;
                cf.Comando.CommandText = query.ToString();
                return cf.Comando.ExecuteReader(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
