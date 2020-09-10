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
using BIT_CRIPTOGRAFIA;
using BIT_MODEL;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using static BIT_ENUMS.Enum;
using BIT_EXCEPTION;

namespace BIT_DESKTOP.View
{
    public partial class FrmCadastroUsuario : MaterialForm
    {
        UsuarioBLL UserBLL = new UsuarioBLL();
        UsuarioModel userModel = new UsuarioModel();
        public static int cod;

        private Form f;

        public Form F { get => f; set => f = value; }
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
           
            try
            {

                if (txtSenha.Text != txtConfirmaSenha.Text)
                {
                   MessageBox.Show("Senha e Confirmação de senha não conferem!!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                string CPF = txtCpf.Text.Replace(".", "").Replace("-", "").Replace("000.000.000-00", "").Trim();
                if (string.IsNullOrEmpty(CPF))
                {
                   throw new ExceptionErro("CPF do usuário é necessário para prosseguir!");

                }
                string Nome = txtNome.Text;
                if (string.IsNullOrEmpty(Nome))
                {
                    throw new ExceptionErro("Nome do usuário é necessário para prosseguir!");

                }

                string DataNasciemento = txtCpf.Text.Replace("_", "").Replace("-", "").Replace("00/00/0000", "").Trim();
                if (string.IsNullOrEmpty(DataNasciemento))
                {
                    throw new ExceptionErro("Data de nascimento do usuário é necessário para prosseguir!");

                }
                string email = txtEmail.Text;
                if (string.IsNullOrEmpty(email))
                {
                    throw new ExceptionErro("Email do usuário é necessário para prosseguir!");

                }
                string Senha = txtSenha.Text;
                if (string.IsNullOrEmpty(Senha))
                {
                    throw new ExceptionErro("Senha do usuário é necessário para prosseguir!");

                }
                if (txtCpf.Text != string.Empty)
                {
                    if (!CPF_Exception.ValidaCPF(txtCpf.Text))
                    {
                        throw new ExceptionErro("CPF Inválido.");
                    }
                }

                if (txtEmail.Text != string.Empty)
                {
                    if (!EMAIL_Exception.ValidaEmail(txtEmail.Text))
                    {
                        throw new ExceptionErro("E-mail Inválido.");
                    }
                }

                int sexo,status,tipo;
                if(cbxSexo.Text == "Masculino")
                {
                    sexo = 1;
                }
                else
                {
                    sexo = 2;
                }
                if(cbxStatus.Text == "Ativo")
                {
                    status = 1;
                }
                else
                {
                    status = 2;
                }
                if(cbxTipoUser.Text == "Desktop")
                {
                    tipo = 1;
                }
                else
                {
                    tipo = 2;
                }
                int cod = Convert.ToInt32(txtId.Text);
                if (cod > 0)
                {
                    userModel.Id = cod;
                    userModel.Nome = txtNome.Text;
                    userModel.Cpf = txtCpf.Text;
                    userModel.DataNascimento = Convert.ToDateTime(txtNascimento.Text);
                    userModel.Email = txtEmail.Text;
                    userModel.Sexo = sexo;
                    userModel.Status = status;
                    userModel.Tipo = tipo;
                    userModel.DataCadastro = Convert.ToDateTime(txtDataCadastro.Text);
                    userModel.Senha = Criptografia.GerarMD5(txtSenha.Text);


                    UserBLL.AlterarUsuario(userModel);

                    MessageBox.Show("Usuário atualizado com sucesso", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    userModel.Nome = txtNome.Text;
                    userModel.Cpf = txtCpf.Text;
                    userModel.DataNascimento = Convert.ToDateTime(txtNascimento.Text);
                    userModel.Email = txtEmail.Text;
                    userModel.Sexo = sexo;
                    userModel.Status = status;
                    userModel.Tipo = tipo;
                    userModel.DataCadastro = Convert.ToDateTime(txtDataCadastro.Text);
                    userModel.Senha = Criptografia.GerarMD5(txtSenha.Text);


                    UserBLL.Insert(userModel);

                    MessageBox.Show("Usuário cadastrado com sucesso", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmListaUsuario listUser = new FrmListaUsuario();
            listUser.CarregarUsuario();
        }

        private void CarregarEnum()
        {
            cbxSexo.DataSource = Enum.GetNames(typeof(EnumSexo));
            cbxSexo.DataSource = Enum.GetValues(typeof(EnumSexo));
            cbxStatus.DataSource = Enum.GetNames(typeof(EnumStatus));
            cbxTipoUser.DataSource = Enum.GetNames(typeof(EnumTipoUsuario));
            //cbxSexo.data();
        }


        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {
            CarregarEnum();
            Mask();
           
        }

        private void Mask()
        {
            if(txtNome.Text == "")
            {
                txtCpf.Text = "";
                txtCpf.Mask = "000,000,000-00";

                txtNascimento.Text = "";
                txtNascimento.Mask = "00/00/0000";

                txtDataCadastro.Text = DateTime.Today.ToString("dd/MM/yyyy");
            }
            
        }

        public void editarUsuario(int id)
        {
            int cod = 0;
            UsuarioModel U = new UsuarioBLL().SelecionarPorID(id);

            if(U.Sexo == 1)
            {
               cbxSexo.Text = "Masculino";
            }
            else
            {
                cbxSexo.Text = "Feminino";
            }

            if(U.Status == 1)
            {
                cbxStatus.Text = "Ativo";
            }
            else
            {
                cbxStatus.Text = "Inativo";
            }

            if(U.Tipo == 1)
            {
                cbxTipoUser.Text = "Desktop";
            }
            else
            {
                cbxTipoUser.Text = "Mobile";
            }

            txtId.Text = Convert.ToInt32(U.Id).ToString();
            txtNome.Text = U.Nome.ToString();
            txtCpf.Text = U.Cpf.ToString();
            txtNascimento.Text = U.DataNascimento.Date.ToString("dd/MM/yyyy");
            //txtHoraAgendamento.Text = a.HoraAgendamento.Date.ToString("HH:mm");
            txtEmail.Text = U.Email.ToString();
            txtDataCadastro.Text = U.DataCadastro.Date.ToString("dd/MM/yyyy");

            //Alterar nome do botão
            btnCadastrar.Text = "Atualizar";
        }
    }
}
