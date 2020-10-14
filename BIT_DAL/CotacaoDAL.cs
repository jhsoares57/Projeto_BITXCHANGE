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
    public class CotacaoDAL
    {
        ConnectionFactory cf = new ConnectionFactory();
        public DataTable ListarCotacaoMoeda()
        {
            cf = new ConnectionFactory();
            string query = "USP_LEVANTAR_COTACAO_MOEDA";

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

        public MoedaModel LevantarCotacao(int id)
        {
            cf = new ConnectionFactory();
            string query = "USP_LEVANTAR_COTACAO";

            cf.Comando = cf.Conexao.CreateCommand();
            cf.Comando.CommandType = CommandType.StoredProcedure;
            cf.Comando.CommandText = query.ToString();

            cf.Comando.Parameters.AddWithValue("@ID_MOEDA", id);

            //Cria um objeto nulo
            MoedaModel Moed = null;

            cf.Conexao.Open();//Abre a conexão

            //Executando o comando
            SqlDataReader dr = cf.Comando.ExecuteReader();

            if (dr.Read())
            {
                Moed = new MoedaModel();//Instanciando o objeto 
                //Preenchimento das propriedades a partir do que retornou no banco.
                Moed.Valor = Convert.ToDecimal(dr["COT_DEC_VALORCOT"]);
               

            }
            //Fechando a conexão
            cf.Conexao.Close();

            //Retornando a lista já carregada.
            return Moed;
        }
    }
}
