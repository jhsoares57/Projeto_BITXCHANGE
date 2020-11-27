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
                cf.Comando.Parameters.AddWithValue("@TIPO", U.Tipo);
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

        public void alterarUsuario(UsuarioModel U)
        {
            try
            {
                string query = "USP_USUARIO_UPDATE";

                //Connection Factory: Classe que gerencia o local da conexão, tendo o método responsável por obter a conexão
                cf = new ConnectionFactory();

                //CreateCommand: Inicializa o objeto SqlCommand associando o Comando com a conexão do Banco onde será executado
                cf.Comando = cf.Conexao.CreateCommand();

                //Abaixo os parametros que no momento da execução serão substituídos pelos valor das propriedades
                cf.Comando.Parameters.AddWithValue("@ID", U.Id);
                cf.Comando.Parameters.AddWithValue("@NOME", U.Nome);
                cf.Comando.Parameters.AddWithValue("@CPF", U.Cpf);
                cf.Comando.Parameters.AddWithValue("@DTNASCIMENTO", U.DataNascimento);
                cf.Comando.Parameters.AddWithValue("@SEXO", U.Sexo);
                cf.Comando.Parameters.AddWithValue("@EMAIL", U.Email);
                cf.Comando.Parameters.AddWithValue("@SENHA", U.Senha);
                cf.Comando.Parameters.AddWithValue("@STATUS", U.Status);
                cf.Comando.Parameters.AddWithValue("@TIPO", U.Tipo);
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

        public DataTable ListarUsuario()
        {
            cf = new ConnectionFactory();
            string query = "USP_LEVANTAR_USER";

            cf.Comando = cf.Conexao.CreateCommand();
            cf.Comando.CommandType = CommandType.StoredProcedure;
            cf.Comando.CommandText = query.ToString();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cf.Comando);

            cf.Conexao.Open();
            da.Fill(dt);
            cf.Conexao.Close();

            return dt;
        }

        public UsuarioModel SelecionarPorID(int id)
        {
            cf = new ConnectionFactory();
            string query = "USP_LEVANTAR_USER_EDITAR";

            cf.Comando = cf.Conexao.CreateCommand();
            cf.Comando.CommandType = CommandType.StoredProcedure;
            cf.Comando.CommandText = query.ToString();

            cf.Comando.Parameters.AddWithValue("@ID", id);

            //Cria um objeto nulo
            UsuarioModel User = null;

            cf.Conexao.Open();//Abre a conexão

            //Executando o comando
            SqlDataReader dr = cf.Comando.ExecuteReader();

            if (dr.Read())
            {
                User = new UsuarioModel();//Instanciando o objeto 
                //Preenchimento das propriedades a partir do que retornou no banco.
                User.Id = Convert.ToInt32(dr["USU_INT_ID"]);
                User.Nome = Convert.ToString(dr["USU_STR_NOME"]);
                User.Cpf = Convert.ToString(dr["USU_STR_CPF"]);
                User.DataNascimento = Convert.ToDateTime(dr["USU_DT_DTNASCIMENTO"]);
                User.Sexo = Convert.ToInt32(dr["USU_STR_SEXO"]);
                User.Email = Convert.ToString(dr["USU_STR_EMAIL"]);
                User.Senha = Convert.ToString(dr["USU_STR_SENHA"]);
                User.Status = Convert.ToInt32(dr["USU_STR_STATUS"]);
                User.DataCadastro = Convert.ToDateTime(dr["USU_DT_DTCADASTRO"]);

            }
            //Fechando a conexão
            cf.Conexao.Close();

            //Retornando a lista já carregada.
            return User;
        }

        public DataTable FiltarUsuario( string nomeUsuario)
        {
            cf = new ConnectionFactory();
            string query = "USP_FILTRAR_USER";

            cf.Comando = cf.Conexao.CreateCommand();
            cf.Comando.CommandType = CommandType.StoredProcedure;
            cf.Comando.CommandText = query.ToString();

            cf.Comando.Parameters.AddWithValue("@NOME", nomeUsuario);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cf.Comando);

            cf.Conexao.Open();
            da.Fill(dt);
            cf.Conexao.Close();

            return dt;
        }

        public void alterarSenha(UsuarioModel U)
        {
            try
            {
                string query = "SP_ALTERAR_SENHA";

                //Connection Factory: Classe que gerencia o local da conexão, tendo o método responsável por obter a conexão
                cf = new ConnectionFactory();

                //CreateCommand: Inicializa o objeto SqlCommand associando o Comando com a conexão do Banco onde será executado
                cf.Comando = cf.Conexao.CreateCommand();

                //Abaixo os parametros que no momento da execução serão substituídos pelos valor das propriedades
                
                cf.Comando.Parameters.AddWithValue("@EMAIL", U.Email);
                cf.Comando.Parameters.AddWithValue("@SENHA", U.Senha);

                cf.Comando.Parameters.AddWithValue("@RETURN", 0).Direction = ParameterDirection.Output;

                //CommandType indica que o Comando será via procedure no banco de dados
                cf.Comando.CommandType = CommandType.StoredProcedure;

                //CommandText: Propriedade do objeto command que receberá o texto do Comando a ser executado.
                cf.Comando.CommandText = query.ToString();

                //Abre a conexão 
                cf.Conexao.Open();
                U.Id = 0;//Define o ID inicialmente como 0.

                cf.Comando.ExecuteNonQuery();//Execução do Comando no Banco de dados        
                object o = cf.Comando.Parameters["@RETURN"].Value;
                cf.Conexao.Close();

                if (o != null)
                {
                    U.Id = 1;
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

        public bool ExisteCpf(string cpf)
        {
            string query = "SELECT COUNT(1) FROM TB_USUARIO WHERE USU_STR_CPF = @CPF";
            //Connection Factory: Classe que gerencia o local da conexão, tendo o método responsável por obter a conexão
            cf = new ConnectionFactory();

            //CreateCommand: Inicializa o objeto SqlCommand associando o Comando com a conexão do Banco onde será executado
            cf.Comando = cf.Conexao.CreateCommand();
            // {

            cf.Comando.Parameters.AddWithValue("@CPF", cpf);

            cf.Comando.CommandText = query.ToString();

            cf.Conexao.Open();


                var result = cf.Comando.ExecuteScalar();

                // Call Read before accessing data.
                if (result != null)
                {
                    return (int)result > 0;
                }

                return false;
            
        }

        public bool ExisteEmail(string email)
        {
            string query = "SELECT COUNT(1) FROM TB_USUARIO WHERE USU_STR_EMAIL = @EMAIL";
            //Connection Factory: Classe que gerencia o local da conexão, tendo o método responsável por obter a conexão
            cf = new ConnectionFactory();

            //CreateCommand: Inicializa o objeto SqlCommand associando o Comando com a conexão do Banco onde será executado
            cf.Comando = cf.Conexao.CreateCommand();
            // {

            cf.Comando.Parameters.AddWithValue("@EMAIL", email);

            cf.Comando.CommandText = query.ToString();

            cf.Conexao.Open();

            var result = cf.Comando.ExecuteScalar();

            // Call Read before accessing data.
            if (result != null)
            {
               
                return (int)result > 0;
            }

            return false;

        }
    }
}
