using BIT_ACESSABANCO;
using BIT_MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT_DAL
{
    public class ConversaoDAL
    {
        ConnectionFactory cf = new ConnectionFactory();
        public void InserirConversao(ConversaoModel C)
        {
            try
            {
                string query = "USP_INSERT_CONVERSAO";

                //Connection Factory: Classe que gerencia o local da conexão, tendo o método responsável por obter a conexão
                cf = new ConnectionFactory();

                //CreateCommand: Inicializa o objeto SqlCommand associando o Comando com a conexão do Banco onde será executado
                cf.Comando = cf.Conexao.CreateCommand();

                //Abaixo os parametros que no momento da execução serão substituídos pelos valor das propriedades
                cf.Comando.Parameters.AddWithValue("@USUARIO", C.IdUsurio);
                cf.Comando.Parameters.AddWithValue("@MOEDA_ORI", C.MoedaOrigem);
                cf.Comando.Parameters.AddWithValue("@MOEDA_FIM", C.MoedaFim);
                cf.Comando.Parameters.AddWithValue("@VALOR_IN", C.ValorInicio);
                cf.Comando.Parameters.AddWithValue("@VALOR_FI", C.ValorFinal);
                cf.Comando.Parameters.AddWithValue("@PROTOCOLO", C.Protocolo);
                cf.Comando.Parameters.AddWithValue("@DATA", C.Data);

                cf.Comando.Parameters.AddWithValue("@ID_OUT", 0).Direction = ParameterDirection.Output;

                //CommandType indica que o Comando será via procedure no banco de dados
                cf.Comando.CommandType = CommandType.StoredProcedure;

                //CommandText: Propriedade do objeto command que receberá o texto do Comando a ser executado.
                cf.Comando.CommandText = query.ToString();

                //Abre a conexão 
                cf.Conexao.Open();
                C.IdConversao = 0;//Define o ID inicialmente como 0.

                cf.Comando.ExecuteNonQuery();//Execução do Comando no Banco de dados        
                object o = cf.Comando.Parameters["@ID_OUT"].Value;//Recuperando o ID salvo (que deverá ser > 0).


                if (o != null)
                {
                    C.IdConversao = Convert.ToInt32(o);
                }
                else
                {
                    C.IdConversao = 0;
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
