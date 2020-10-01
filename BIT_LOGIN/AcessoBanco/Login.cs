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
        
        public DadosLogin FindByLogin(string nmUsuario, string senhausuario, int tipo, string DescUser)
        {
            //DadosLogin L = null;

            cf = new ConnectionFactory();

            // string query = "SELECT NM_USUARIO,SENHA_USUARIO   FROM LOGINN ";
            string query = "USP_USUARIOS_SEL";

            cf.Comando = cf.Conexao.CreateCommand();

            cf.Comando.CommandType = CommandType.StoredProcedure;

            cf.Comando.CommandText = query;

            cf.Comando.Parameters.AddWithValue("@LOGIN", nmUsuario);
            cf.Comando.Parameters.AddWithValue("@SENHA", senhausuario);
            cf.Conexao.Open();



            SqlDataReader dr = cf.Comando.ExecuteReader();

            if (dr.Read())
            {
                //L = new DadosLogin();
                L.Id = Convert.ToInt32(dr["USU_INT_ID"]);
                L.Email = Convert.ToString(dr["USU_STR_EMAIL"]);
                L.Senha = Convert.ToString(dr["USU_STR_SENHA"]);
                L.Nome = Convert.ToString(dr["USU_STR_NOME"]);
                L.Tipo = Convert.ToInt32(dr["USU_STR_TIPO"]);


            }

            cf.Conexao.Close();

            return L;
        }
    }
}
