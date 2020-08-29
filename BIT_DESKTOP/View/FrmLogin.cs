using BIT_LOGIN.Model;
using BIT_LOGIN.Negocio;
using Library.Utils;
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
    public partial class FrmLogin : MaterialForm
    {
        public FrmLogin()
        {
            InitializeComponent();
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
                    this.Hide();
                    FrmPrincipal inicial = new FrmPrincipal();
                    inicial.Show();
                }
                else
                {
                    MessageBox.Show ("Usuario Incorreto ou senha incorreta", "Mensagem do Sistema");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
