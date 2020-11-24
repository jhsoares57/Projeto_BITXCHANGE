using BIT_ACESSABANCO;
using BIT_MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT_DAL
{
    public class TransacaoDAL
    {
        ConnectionFactory cf = new ConnectionFactory();
        public DataTable ListarRelatorioTransacoes(DateTime DataInicial)
        {
            cf = new ConnectionFactory();
            string query = "USP_RELATORIO_TRANSACOES";

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.CommandType = CommandType.StoredProcedure;
            cf.Comando.CommandText = query.ToString();

            cf.Comando.Parameters.AddWithValue("@DATAINCIAL", DataInicial);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cf.Comando);

            cf.Conexao.Open();
            da.Fill(dt);
            cf.Conexao.Close();

            return dt;
        }

        public DataTable ListarRelatorioTransacoesMensal(DateTime DataInicial, DateTime DataFinal)
        {
            cf = new ConnectionFactory();
            string query = "USP_RELATORIO_TRANSACOES_MENSAL";

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.CommandType = CommandType.StoredProcedure;
            cf.Comando.CommandText = query.ToString();

            cf.Comando.Parameters.AddWithValue("@DATAINCIAL", DataInicial);
            cf.Comando.Parameters.AddWithValue("@DATAFINAL", DataFinal);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cf.Comando);

            cf.Conexao.Open();
            da.Fill(dt);
            cf.Conexao.Close();

            return dt;
        }

        public DataTable ListarUltimasTransacoesMensal()
        {
            cf = new ConnectionFactory();
            string query = "USP_ULTIMAS_TRANSACOES";

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

        public DataTable ListarExtratouserDAL(int id)
        {
            cf = new ConnectionFactory();
            string query = "USP_EXTRATO_USUARIO";

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.CommandType = CommandType.StoredProcedure;
            cf.Comando.CommandText = query.ToString();
            cf.Comando.Parameters.AddWithValue("@USUARIO", id);


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cf.Comando);

            cf.Conexao.Open();
            da.Fill(dt);
            cf.Conexao.Close();

            return dt;
        }

        public DataTable Lista(int id)
        {
            cf = new ConnectionFactory();
            string query = "USP_EXTRATO_USUARIO_3";

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.CommandType = CommandType.StoredProcedure;
            cf.Comando.CommandText = query.ToString();
            cf.Comando.Parameters.AddWithValue("@USUARIO", id);
          

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cf.Comando;

            DataTable table = new DataTable();
            cf.Conexao.Open();
            adapter.Fill(table);
                return table;
            
        }

        public DataTable ListaTodasTransacoes(int id)
        {
            cf = new ConnectionFactory();
            string query = "USP_EXTRATO_USUARIO";

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.CommandType = CommandType.StoredProcedure;
            cf.Comando.CommandText = query.ToString();
            cf.Comando.Parameters.AddWithValue("@USUARIO", id);


            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cf.Comando;

            DataTable table = new DataTable();
            cf.Conexao.Open();
            adapter.Fill(table);
            return table;

        }

        public void InserirTransaferencia(TransacaoModel T)
        {
            try
            {
                string query = "USP_INSERIR_TRANSFERENCIA";

                //Connection Factory: Classe que gerencia o local da conexão, tendo o método responsável por obter a conexão
                cf = new ConnectionFactory();

                //CreateCommand: Inicializa o objeto SqlCommand associando o Comando com a conexão do Banco onde será executado
                cf.Comando = cf.Conexao.CreateCommand();

                //Abaixo os parametros que no momento da execução serão substituídos pelos valor das propriedades
                cf.Comando.Parameters.AddWithValue("@TRA_STR_DESC", T.Descricao);
                cf.Comando.Parameters.AddWithValue("@TRA_DOU_VALOR", T.Valor);
                cf.Comando.Parameters.AddWithValue("@TRA_DT_DATATRANS", T.DataTransacao);
                cf.Comando.Parameters.AddWithValue("@TRA_STR_PROTOCOLO", T.Protocolo);
                cf.Comando.Parameters.AddWithValue("@MOE_INT_ID", T.Moeda);
                cf.Comando.Parameters.AddWithValue("@USU_INT_ID", T.Usuario);

                cf.Comando.Parameters.AddWithValue("@ID_OUT", 0).Direction = ParameterDirection.Output;

                //CommandType indica que o Comando será via procedure no banco de dados
                cf.Comando.CommandType = CommandType.StoredProcedure;

                //CommandText: Propriedade do objeto command que receberá o texto do Comando a ser executado.
                cf.Comando.CommandText = query.ToString();

                //Abre a conexão 
                cf.Conexao.Open();
                T.Id = 0;//Define o ID inicialmente como 0.

                cf.Comando.ExecuteNonQuery();//Execução do Comando no Banco de dados        
                object o = cf.Comando.Parameters["@ID_OUT"].Value;//Recuperando o ID salvo (que deverá ser > 0).
                

                if (o != null)
                {
                    T.Id = Convert.ToInt32(o);
                }
                else
                {
                    T.Id = 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cf.Conexao.Close();
            }
        }
    }
}
