using BIT_ACESSABANCO;
using BIT_MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT_DAL
{
    public class UsuarioDAL
    {
        ConnectionFactory cf = new ConnectionFactory();
        public void cadastrarUsuario(UsuarioModel U)
        {
            try
            {
                string query = "USP_USUARIO_INSERT";

                //Connection Factory: Classe que gerencia o local da conexão, tendo o método responsável por obter a conexão
                cf = new ConnectionFactory();

                //CreateCommand: Inicializa o objeto SqlCommand associando o Comando com a conexão do Banco onde será executado
                cf.Comando = cf.Conexao.CreateCommand();

                //Abaixo os parametros que no momento da execução serão substituídos pelos valor das propriedades
                //cf.Comando.Parameters.AddWithValue("@ID_CLINTE", c.Id);
                cf.Comando.Parameters.AddWithValue("@NOME", U.Nome);
                cf.Comando.Parameters.AddWithValue("@CPF", U.Cpf);
                cf.Comando.Parameters.AddWithValue("@DTNASCIMENTO", U.DataNascimento);
                cf.Comando.Parameters.AddWithValue("@SEXO", U.Sexo);
                cf.Comando.Parameters.AddWithValue("@EMAIL", U.Email);
                cf.Comando.Parameters.AddWithValue("@SENHA", U.Senha);
                cf.Comando.Parameters.AddWithValue("@STATUS", U.Status);
                cf.Comando.Parameters.AddWithValue("@@TIPO", U.Tipo);
                cf.Comando.Parameters.AddWithValue("@DTCADASTRO", U.DataCadastro);

                cf.Comando.Parameters.AddWithValue("@ID_OUT", 0).Direction = ParameterDirection.Output;

                //CommandType indica que o Comando será via procedure no banco de dados
                cf.Comando.CommandType = CommandType.StoredProcedure;

                //CommandText: Propriedade do objeto command que receberá o texto do Comando a ser executado.
                cf.Comando.CommandText = query.ToString();

                //Abre a conexão 
                cf.Conexao.Open();
                U.Id = 0;//Define o ID inicialmente como 0.

                cf.Comando.ExecuteNonQuery();//Execução do Comando no Banco de dados        
                object o = cf.Comando.Parameters["@ID_OUT"].Value;//Recuperando o ID salvo (que deverá ser > 0).
                cf.Conexao.Close();

                if (o != null)
                {
                    U.Id = Convert.ToInt32(o);
                }
                else
                {
                    U.Id = 0;
                }
            }
            catch (Exception ex)
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
                return cf.Comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
