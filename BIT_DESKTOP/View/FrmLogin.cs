using BIT_LOGIN.Model;
using BIT_LOGIN.Negocio;
using BIT_CRIPTOGRAFIA;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIT_DESKTOP.View
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            // Criando um material theme manager e adicionando o formulário
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Definindo um esquema de Cor para formulário com tom Azul
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Orange500, Primary.Orange500,
                Primary.Orange500, Accent.Orange700,
                TextShade.BLACK
            );
        }

        
        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Digite Usuário e Senha!", "Mensagem");
                txtEmail.Focus();
                return;
            }


            try
            {
                LoginNeg uService = new LoginNeg();
                DadosLogin usuario = new DadosLogin();

                usuario = uService.FindByLogin(txtEmail.Text, Criptografia.GerarMD5(txtSenha.Text));

                if (usuario.Email != null)
                {
                    if(usuario.Tipo == 1)
                    {
                        this.Hide();
                        FrmPrincipal inicial = new FrmPrincipal();
                        inicial.NomeUser(usuario.Nome,usuario.Id);
                        inicial.Show();
                       
                    }
                    else
                    {
                        MessageBox.Show("Usuário não tem acesso ao modulo dektop!!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    MessageBox.Show ("Usuário ou senha incorreta !!", "Mensagem do Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtEmail.Clear();
                    txtSenha.Clear();
                    txtEmail.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
