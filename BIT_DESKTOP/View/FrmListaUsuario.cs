using BIT_BLL;
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
    public partial class FrmListaUsuario : MaterialForm
    {
        UsuarioBLL Userbll = new UsuarioBLL();
        public static int ID;
        public FrmListaUsuario()
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

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FrmCadastroUsuario user = new FrmCadastroUsuario();
            user.MdiParent = this.MdiParent;
            user.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CarregarUsuario()
        {
            dgvCarregarUsuario.DataSource = Userbll.SelecionarUsuario();
        }

        private void FrmListaUsuario_Load(object sender, EventArgs e)
        {
            CarregarUsuario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCadastroUsuario UserCad = new FrmCadastroUsuario();
                if (ID > 0)
                {
                    UserCad.F = this;
                    UserCad.editarUsuario(ID);
                    UserCad.MdiParent = this.MdiParent;
                    UserCad.Show();
                }
                else
                {
                    MessageBox.Show("Selecione um usuário", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                throw;
            }
           
           
        }

        private void dgvCarregarUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dgvCarregarUsuario.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                MessageBox.Show("Selecione um usuário","Mensagem do sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
