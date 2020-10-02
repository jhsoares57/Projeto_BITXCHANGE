using BIT_ACESSABANCO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT_BACKUP
{
    public class ExecBackup
    {
        ConnectionFactory con = new ConnectionFactory();
        public void Backups(string dir)
        {
            
            string database = con.Conexao.Database.ToString();

            try
            {
                con = new ConnectionFactory();
                string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + dir + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".bak'";

                using (SqlCommand command = new SqlCommand(cmd, con.Conexao))
                {
                    if (con.Conexao.State != ConnectionState.Open)
                    {
                        con.Conexao.Open();
                    }
                    command.ExecuteNonQuery();
                    con.Conexao.Close();
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        public void GravarLogBackup( DateTime data, string database,string diretorio,string status, int usuario)
        {
            try
            {
                string query = "USP_INSERT_LOG_BACKUP";

                //Connection Factory: Classe que gerencia o local da conexão, tendo o método responsável por obter a conexão
                con = new ConnectionFactory();

                //CreateCommand: Inicializa o objeto SqlCommand associando o Comando com a conexão do Banco onde será executado
                con.Comando = con.Conexao.CreateCommand();

                //Abaixo os parametros que no momento da execução serão substituídos pelos valor das propriedades
                //con.Comando.Parameters.AddWithValue("@ID_CLINTE", c.Id);
                con.Comando.Parameters.AddWithValue("@DATA", data);
                con.Comando.Parameters.AddWithValue("@DATABASE", database);
                con.Comando.Parameters.AddWithValue("@DIRETORIO", diretorio);
                con.Comando.Parameters.AddWithValue("@TATUS", status);
                con.Comando.Parameters.AddWithValue("@USUARIO", usuario);

                //CommandType indica que o Comando será via procedure no banco de dados
                con.Comando.CommandType = CommandType.StoredProcedure;

                //CommandText: Propriedade do objeto command que receberá o texto do Comando a ser executado.
                con.Comando.CommandText = query.ToString();

                //Abre a conexão 
                con.Conexao.Open();

                con.Comando.ExecuteNonQuery();//Execução do Comando no Banco de dados        
                con.Conexao.Close(); // Fecha conexão
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
