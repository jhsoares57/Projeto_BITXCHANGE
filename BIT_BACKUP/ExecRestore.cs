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
    public class ExecRestore
    {
        ConnectionFactory con = new ConnectionFactory();
        public void Restore(string caminho)
        {
            
            string database = con.Conexao.Database.ToString();
            con = new ConnectionFactory();
            if (con.Conexao.State != ConnectionState.Open)
            {
                con.Conexao.Open();
            }
            try
            {
                string sqlStmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand bu2 = new SqlCommand(sqlStmt2, con.Conexao);
                bu2.ExecuteNonQuery();

                string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + caminho + "'WITH REPLACE;";
                SqlCommand bu3 = new SqlCommand(sqlStmt3, con.Conexao);
                bu3.ExecuteNonQuery();

                string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand bu4 = new SqlCommand(sqlStmt4, con.Conexao);
                bu4.ExecuteNonQuery();

                
                con.Conexao.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
