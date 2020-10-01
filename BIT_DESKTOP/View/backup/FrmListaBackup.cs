using BIT_BACKUP;
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

namespace BIT_DESKTOP.View.backup
{
    public partial class FrmListaBackup : MaterialForm
    {
        ListarBackup listaBackup = new ListarBackup();
        public FrmListaBackup()
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
                TextShade.BLACK);
        }
        Label lblnome = new Label();
        Label lblidUser = new Label();
        public void dadosUser(string nomeUser, int idUser)
        {
            string nome = nomeUser;
            int id = idUser;

            lblnome.Text = nome;
            lblidUser.Text = Convert.ToInt32(idUser).ToString();
        }
        private void btnGerarBackup_Click(object sender, EventArgs e)
        {
            FrmBackup Gerar = new FrmBackup();
            Gerar.MdiParent = this.MdiParent;
            Gerar.dadosUser(lblnome.Text, Convert.ToInt32(lblidUser.Text));
            Gerar.Show();
        }

        private void FrmListaBackup_Load(object sender, EventArgs e)
        {
          dgvListaBackup.DataSource =  listaBackup.ListarUltimosBackups();
        }
    }
}
