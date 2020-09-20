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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            panel1.Dock = DockStyle.Top;
            panel1.AutoSize = false;


            // Criando um material theme manager e adicionando o formulário
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //Definindo um esquema de Cor para formulário com tom laranja
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Orange500, Primary.Orange500,
                Primary.Orange500, Accent.Orange700,
                TextShade.BLACK
            );
        }

        Label lblnome = new Label();
        public void NomeUser(string user)
        {
            string nome = user;
           
            lblnome.Text = nome;
        }

        private void FInicio()
        {
            FrmInicio IncioF = new FrmInicio();
            IncioF.MdiParent = this;
            IncioF.NomeUser(lblnome.Text);
            IncioF.Show();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            FrmListaUsuario user = new FrmListaUsuario();
            user.MdiParent = this;
            user.Show();
        }

        private void btnRelDiario_Click(object sender, EventArgs e)
        {
            View.Relatorio.FrmRelDiario RelDir = new Relatorio.FrmRelDiario();
            RelDir.MdiParent = this;
            RelDir.Show();
        }

        private void btnRelMensal_Click(object sender, EventArgs e)
        {
            View.Relatorio.FrmRelMensal RelMen = new Relatorio.FrmRelMensal();
            RelMen.MdiParent = this;
            RelMen.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            View.FrmInicio Incio = new FrmInicio();
            Incio.MdiParent = this;
            Incio.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FInicio();
        }
    }
}
