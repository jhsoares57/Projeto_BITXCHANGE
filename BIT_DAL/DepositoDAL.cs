using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIT_ACESSABANCO;
using BIT_MODEL;
using System.Data.SqlClient;
using System.Data;

namespace BIT_DAL
{
    public class DepositoDAL
    {
        ConnectionFactory cf = new ConnectionFactory();
        public void inserirDepositoCartao(DepositoModel D)
        {
            try
            {
                string query = "USP_DEPOSITO_CARTAO";

                //Connection Factory: Classe que gerencia o local da conexão, tendo o método responsável por obter a conexão
                cf = new ConnectionFactory();

                //CreateCommand: Inicializa o objeto SqlCommand associando o Comando com a conexão do Banco onde será executado
                cf.Comando = cf.Conexao.CreateCommand();

                //Abaixo os parametros que no momento da execução serão substituídos pelos valor das propriedades
                //cf.Comando.Parameters.AddWithValue("@ID_CLINTE", c.Id);
                cf.Comando.Parameters.AddWithValue("@TIPO", D.Tipo);
                cf.Comando.Parameters.AddWithValue("@TITULAR", D.Titular);
                cf.Comando.Parameters.AddWithValue("@DTVENCIMENTO", D.DataVencimento);
                cf.Comando.Parameters.AddWithValue("@NUMCARTAO", D.NumCartao);
                cf.Comando.Parameters.AddWithValue("@CVV", D.Cvv);
                cf.Comando.Parameters.AddWithValue("@DTPAGAMENTO", D.DataPagamento);
                cf.Comando.Parameters.AddWithValue("@DPVALOR", D.Valor);
                cf.Comando.Parameters.AddWithValue("@STATUS", D.Status);
                cf.Comando.Parameters.AddWithValue("@CARTEIRAID", D.Carteira);
                cf.Comando.Parameters.AddWithValue("@PROTOCOLO", D.Protocolo);

                cf.Comando.Parameters.AddWithValue("@USERID", D.Id);

                cf.Comando.Parameters.AddWithValue("@ID_OUT", 0).Direction = ParameterDirection.Output;

                //CommandType indica que o Comando será via procedure no banco de dados
                cf.Comando.CommandType = CommandType.StoredProcedure;

                //CommandText: Propriedade do objeto command que receberá o texto do Comando a ser executado.
                cf.Comando.CommandText = query.ToString();

                //Abre a conexão 
                cf.Conexao.Open();
                D.Id = 0;//Define o ID inicialmente como 0.

                cf.Comando.ExecuteNonQuery();//Execução do Comando no Banco de dados        
                object o = cf.Comando.Parameters["@ID_OUT"].Value;//Recuperando o ID salvo (que deverá ser > 0).
                cf.Conexao.Close();

                if (o != null)
                {
                    D.Id = Convert.ToInt32(o);
                }
                else
                {
                    D.Id = 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void inserirDepositoBoleto(DepositoModel D)
        {
            try
            {
                string query = "USP_DEPOSITO_BOLETO";

                //Connection Factory: Classe que gerencia o local da conexão, tendo o método responsável por obter a conexão
                cf = new ConnectionFactory();

                //CreateCommand: Inicializa o objeto SqlCommand associando o Comando com a conexão do Banco onde será executado
                cf.Comando = cf.Conexao.CreateCommand();

                //Abaixo os parametros que no momento da execução serão substituídos pelos valor das propriedades
                //cf.Comando.Parameters.AddWithValue("@ID_CLINTE", c.Id);
                cf.Comando.Parameters.AddWithValue("@TIPO", D.Tipo);
                cf.Comando.Parameters.AddWithValue("@TITULAR", D.Titular);
                cf.Comando.Parameters.AddWithValue("@DTVENCIMENTO", D.DataVencimento);
                cf.Comando.Parameters.AddWithValue("@DTPAGAMENTO", D.DataPagamento);
                cf.Comando.Parameters.AddWithValue("@DPVALOR", D.Valor);
                cf.Comando.Parameters.AddWithValue("@STATUS", D.Status);
                cf.Comando.Parameters.AddWithValue("@CARTEIRAID", D.Carteira);
                cf.Comando.Parameters.AddWithValue("@PROTOCOLO", D.Protocolo);
                cf.Comando.Parameters.AddWithValue("@NUMBLT", D.NumBoleto);

                cf.Comando.Parameters.AddWithValue("@USERID", D.Id);

                cf.Comando.Parameters.AddWithValue("@ID_OUT", 0).Direction = ParameterDirection.Output;

                //CommandType indica que o Comando será via procedure no banco de dados
                cf.Comando.CommandType = CommandType.StoredProcedure;

                //CommandText: Propriedade do objeto command que receberá o texto do Comando a ser executado.
                cf.Comando.CommandText = query.ToString();

                //Abre a conexão 
                cf.Conexao.Open();
                D.Id = 0;//Define o ID inicialmente como 0.

                cf.Comando.ExecuteNonQuery();//Execução do Comando no Banco de dados        
                object o = cf.Comando.Parameters["@ID_OUT"].Value;//Recuperando o ID salvo (que deverá ser > 0).
                cf.Conexao.Close();

                if (o != null)
                {
                    D.Id = Convert.ToInt32(o);
                }
                else
                {
                    D.Id = 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
