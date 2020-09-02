using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace BIT_DESKTOP.View
{
    public partial class FrmCadastroUsuario : Form
    {
        public FrmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string strConn = ""; // STRING DE CONEXAO
            string query = "INSERT INTO TB_USUARIO (" + txtNome.Text + "," + txtCpf.Text + "," + txtNascimento.Text + "," + txtEmail.Text + "," + txtSenha.Text + "," + txtSexo.Text + ") VALUES (@USU_STR_NOME, @USU_STR_CPF, @USU_DT_DTNASCIMENTO, @USU_STR_EMAIL, @USU_STR_SENHA, @USU_STR_SEXO)";
            SqlConnection con = new SqlConnection(strConn);
            SqlCommand sqlCMD = new SqlCommand(query, con);

            con.Open();

            sqlCMD.ExecuteNonQuery();

            con.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
