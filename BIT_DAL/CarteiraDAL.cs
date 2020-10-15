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
    public class CarteiraDAL
    {
        ConnectionFactory cf;
        public CarteiraModel RetornaSaldoCartiraPorID( int id_usuario, int Moeda)
        {
            cf = new ConnectionFactory();
            string query = "USP_SELECIONAR_CARTEIRA_USUARIO";

            cf.Comando = cf.Conexao.CreateCommand();
            cf.Comando.CommandType = CommandType.StoredProcedure;
            cf.Comando.CommandText = query.ToString();

            cf.Comando.Parameters.AddWithValue("@ID", id_usuario);
            cf.Comando.Parameters.AddWithValue("@MOEDA", Moeda);

            //Cria um objeto nulo
            CarteiraModel Cart = null;

            cf.Conexao.Open();//Abre a conexão

            //Executando o comando
            SqlDataReader dr = cf.Comando.ExecuteReader();

            if (dr.Read())
            {
                Cart = new CarteiraModel();//Instanciando o objeto 
                //Preenchimento das propriedades a partir do que retornou no banco.
                Cart.MoedaCart = Convert.ToInt32(dr["MOE_INT_ID"]);
                Cart.SaldoCart = Convert.ToDecimal(dr["MC_DEC_SALDO"]);


            }
            //Fechando a conexão
            cf.Conexao.Close();

            //Retornando a lista já carregada.
            return Cart;
        }       
    }
}
