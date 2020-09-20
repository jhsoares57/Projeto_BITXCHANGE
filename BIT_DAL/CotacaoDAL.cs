using BIT_ACESSABANCO;
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
    }
}
