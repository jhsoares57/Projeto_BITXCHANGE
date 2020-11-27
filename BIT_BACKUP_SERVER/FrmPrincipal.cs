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

namespace BIT_BACKUP_SERVER
{
    public partial class FrmPrincipal : MaterialForm
    {
        ExecBackup backup = new ExecBackup();
        ExecRestore restore = new ExecRestore();
        RetornaDatabase retornaDatabase = new RetornaDatabase();
        public FrmPrincipal()
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
                TextShade.BLACK);
        }

        #region Botões

        private void btnDirBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtDiretorioBackup.Text = dlg.SelectedPath;

            }

        }

        private void btnprocessarBackup_Click(object sender, EventArgs e)
        {
            if(rdbtBackup.Checked == true)
            {
                tmBack.Enabled = true;
                prgBackup.Visible = true;
            }
            else
            {
                tmRestore.Enabled = true;
                prgBackup.Visible = true;
            }





        }
        #endregion

        #region Backup


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
                        int idUser = Convert.ToInt32(1);
                        backup.Backups(diretorio);
                        tmBack.Enabled = false;
                        backup.GravarLogBackup(date, database, diretorio, "F", idUser);

                        MessageBox.Show("Backup realizado com sucesso!!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        MessageBox.Show("Selecione um diretorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    tmBack.Enabled = false;
                }
                catch (Exception ex)
                {
                    DateTime date = DateTime.Today;
                    string database = txtDatabase.Text;
                    string diretorio = txtDiretorioBackup.Text;
                    int idUser = Convert.ToInt32(1);
                    backup.GravarLogBackup(date, database, diretorio, "E", idUser);

                    tmBack.Enabled = false;

                    string message = Convert.ToString(ex);

                    MessageBox.Show(message);
                }
                Visible = (false);
            }
            
        }

        private void tmBack_Tick(object sender, EventArgs e)
        {
            progress();
            
        }
        #endregion

        #region Restore
        private void progresRestore()
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
                        string diretorio = txtDiretorioBackup.Text;
                        
                        restore.Restore(diretorio);
                        tmBack.Enabled = false;
                        MessageBox.Show("Backup restaurado com sucesso!!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        MessageBox.Show("Selecione um diretorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    tmBack.Enabled = false;
                }
                catch (Exception ex)
                {
                    DateTime date = DateTime.Today;
                    string database = txtDatabase.Text;
                    string diretorio = txtDiretorioBackup.Text;
                    int idUser = 1;
                    backup.GravarLogBackup(date, database, diretorio, "E", idUser);

                    tmBack.Enabled = false;

                    string message = Convert.ToString(ex);

                    MessageBox.Show(message);
                }
                Visible = (false);
            }

        }
        private void tmRestore_Tick(object sender, EventArgs e)
        {
            progresRestore();
        }

        #endregion

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
           txtDatabase.Text = retornaDatabase.RetornaBaseConnectiomString();
        }
    }
}
