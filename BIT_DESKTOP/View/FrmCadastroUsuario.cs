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
using BIT_BLL;
using BIT_MODEL;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using static BIT_ENUMS.Enum;

namespace BIT_DESKTOP.View
{
    public partial class FrmCadastroUsuario : MaterialForm
    {
        UsuarioBLL UserBLL = new UsuarioBLL();
        UsuarioModel userModel = new UsuarioModel();
        public FrmCadastroUsuario()
        {
            InitializeComponent();

            // Criando um material theme manager e adicionando o formulário
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Definindo um esquema de Cor para formulário com tom Azul
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Orange500, Primary.Orange500,
                Primary.Orange500, Accent.Orange700,
                TextShade.BLACK
            );

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(txtSenha != txtConfirmaSenha)
            {
                MessageBox.Show("Senha e Confirmação de senha não conferem!!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {

                userModel.Nome = txtNome.Text;
                userModel.Cpf = txtCpf.Text;
                userModel.DataNascimento = Convert.ToDateTime(txtNascimento.Text);
                userModel.Email = txtEmail.Text;
                userModel.Sexo = Convert.ToInt32(cbxSexo.ValueMember).ToString();
                userModel.Status = Convert.ToInt32(cbxStatus.ValueMember).ToString();
                userModel.Tipo = Convert.ToInt32(cbxTipoUser.ValueMember).ToString();
                userModel.DataCadastro = Convert.ToDateTime(txtDataCadastro.Text);
                userModel.Senha = txtSenha.Text;


                UserBLL.Insert(userModel);

                MessageBox.Show("Usuário cadastrado com sucesso", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregarEnum()
        {
            cbxSexo.DataSource = Enum.GetNames(typeof(EnumSexo));
            cbxStatus.DataSource = Enum.GetNames(typeof(EnumStatus));
            cbxTipoUser.DataSource = Enum.GetNames(typeof(EnumTipoUsuario));
            //cbxSexo.data();
        }


        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {
            CarregarEnum();
            
        }
    }
}
