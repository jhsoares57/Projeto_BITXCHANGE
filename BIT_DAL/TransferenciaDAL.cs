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
    public class TransferenciaDAL
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
    }
}
