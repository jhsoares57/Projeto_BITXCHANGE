using BLL;
using DGVPrinterHelper;
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
        TransferenciaBLL TransBLL = new TransferenciaBLL();
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
            CarregarGrid();
        }

        private void CarregarDataAtual()
        {
            txtData.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CarregarGrid()
        {
            DateTime DataInicial = Convert.ToDateTime(txtData.Text);
            dgvListarTransacoes.DataSource = TransBLL.ListarRelatorioTransacoes(DataInicial);
        }

        private void txtData_CloseUp(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnGerarPDF_Click(object sender, EventArgs e)
        {
            this.printDocument.DefaultPageSettings.Landscape = true;
            DGVPrinter print = new DGVPrinter();
            print.Title = "Transações Diarias"; //Titulo da Página
            print.SubTitle = String.Format("Data de geração: {0}", DateTime.Now.Date);
            print.PageSettings.Landscape = true;
            print.PorportionalColumns = true;
            print.PageNumberInHeader = false;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "BitXchange";

            
            print.PrintDataGridView(dgvListarTransacoes);
        }
    }
}
