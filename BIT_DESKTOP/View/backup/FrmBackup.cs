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
    public partial class FrmBackup : MaterialForm

    {
        ExecBackup backup = new ExecBackup();
        RetornaDatabase retornaDatabase = new RetornaDatabase();
        public FrmBackup()
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

        Label lblidUser = new Label();
        public void dadosUser(string nomeUser, int idUser)
        {
            string nome = nomeUser;
            int id = idUser;

            lblidUser.Text = Convert.ToInt32(idUser).ToString();

            txtUser.Text = nomeUser;
        }

        private void btnDirBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtDiretorioBackup.Text = dlg.SelectedPath;
                btnprocessarBackup.Enabled = true;
            }

        }

        private void btnprocessarBackup_Click(object sender, EventArgs e)
        {
            tmBack.Enabled = true;
            prgBackup.Visible = true;
            

        }

        private void progress()
        {


            if (prgBackup.Value < 100)
            {
                prgBackup.Value = prgBackup.Value + 1;
            }
            if (prgBackup.Value == 100)
            {
                try
                {
                    if (txtDiretorioBackup.Text != string.Empty)
                    {
                        DateTime date = DateTime.Today;
                        string database = txtDatabase.Text;
                        string diretorio = txtDiretorioBackup.Text;
                        int idUser = Convert.ToInt32(lblidUser.Text);
                        backup.Backups(diretorio);
                        tmBack.Enabled = false;
                        backup.GravarLogBackup(date, database, diretorio, "F", idUser);

                        MessageBox.Show("Backup realizado com sucesso!!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        MessageBox.Show("Selecione um diretorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    DateTime date = DateTime.Today;
                    string database = txtDatabase.Text;
                    string diretorio = txtDiretorioBackup.Text;
                    int idUser = Convert.ToInt32(lblidUser.Text);
                    backup.GravarLogBackup(date, database, diretorio, "E", idUser);

                    tmBack.Enabled = false;

                    string message = Convert.ToString(ex);

                    MessageBox.Show(message);
                }
                Visible = (false);
                tmBack.Enabled = false;
            }
        }

        private void tmBack_Tick(object sender, EventArgs e)
        {
            progress();
        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {
            txtDatabase.Text = retornaDatabase.RetornaBaseConnectiomString();
        }
    }
}
