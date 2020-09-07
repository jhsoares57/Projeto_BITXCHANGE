using BIT_ACESSABANCO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIT_LOGIN.Model;


namespace BIT_LOGIN.AcessoBanco
{
    public class Login
    {
        ConnectionFactory cf = new ConnectionFactory();
        DadosLogin L = new DadosLogin();
        
        public DadosLogin FindByLogin(string nmUsuario, string senhausuario, int tipo)
        {
            //DadosLogin L = null;

            cf = new ConnectionFactory();

            // string query = "SELECT NM_USUARIO,SENHA_USUARIO   FROM LOGINN ";
            string query = "USP_USUARIOS_SEL ";

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.CommandType = CommandType.StoredProcedure;

            cf.Comando.CommandText = query;

            cf.Comando.Parameters.AddWithValue("@LOGIN", nmUsuario);
            cf.Comando.Parameters.AddWithValue("@SENHA", senhausuario);
            cf.Comando.Parameters.AddWithValue("@TIPO", tipo);
            cf.Conexao.Open();



            SqlDataReader dr = cf.Comando.ExecuteReader();

            if (dr.Read())
            {
                //L = new DadosLogin();
                //U.IdUsuario = Convert.ToInt32(dr["ID_USUARIO"]);
                L.Email = Convert.ToString(dr["USU_STR_EMAIL"]);
                L.Senha = Convert.ToString(dr["USU_STR_SENHA"]);
                //U.DsUsuario = Convert.ToString(dr["DS_USUARIO"]);


            }

            cf.Conexao.Close();

            return L;
        }
    }
}
