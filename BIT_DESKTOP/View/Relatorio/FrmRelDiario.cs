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

namespace BIT_DESKTOP.View.Relatorio
{
    public partial class FrmRelDiario : MaterialForm
    {
        public FrmRelDiario()
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

        private void FrmRelDiario_Load(object sender, EventArgs e)
        {
            CarregarDataAtual();
        }

        private void CarregarDataAtual()
        {
            lblDataAtual.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
