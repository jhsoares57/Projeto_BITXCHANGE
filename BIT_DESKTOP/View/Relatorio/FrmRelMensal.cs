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
    public partial class FrmRelMensal : MaterialForm
    {

        TransferenciaBLL TransBLL = new TransferenciaBLL();
        public static decimal total;
        public static string moeda;
        public static decimal bit;
        public static decimal real;
        public static decimal etherum;
        public static decimal dolar;
        public FrmRelMensal()
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
            dtDataFinal.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CarregarGrid()
        {
            DateTime DataInicial = Convert.ToDateTime(dtDataInicial.Text);
            DateTime DataFinal = Convert.ToDateTime(dtDataFinal.Text);
            dgvListarTransacoes.DataSource = TransBLL.ListarRelatorioTransacoesMensal(DataInicial,DataFinal);

            carregarTotalMoeda();
        }

        private void LimparVariaveis() {
            dolar = 0;
            real = 0;
            etherum = 0;
            bit = 0;
        }

        private void carregarTotalMoeda()
        {
            total = 0;
            foreach (DataGridViewRow linha in dgvListarTransacoes.Rows)
            {
                string moeda = Convert.ToString(linha.Cells[4].Value);
                if (moeda == "BTC")
                {
                    bit += Convert.ToDecimal(linha.Cells[3].Value);

                    lblBitCoin.Text = Convert.ToString(bit);
                }
                if (moeda == "R$")
                {

                    real += Convert.ToDecimal(linha.Cells[3].Value);

                    lblreal.Text = Convert.ToString(real);
                }
                if (moeda == "ETH")
                {

                    etherum += Convert.ToDecimal(linha.Cells[3].Value);

                    lblETHERUN.Text = Convert.ToString(etherum);
                }
                if (moeda == "USD")
                {

                    dolar += Convert.ToDecimal(linha.Cells[3].Value);

                    lblDolar.Text = Convert.ToString(dolar);
                }

            }


        }

       
        private void btnGerarPDF_Click(object sender, EventArgs e)
        {
            this.printDocument.DefaultPageSettings.Landscape = true;
            DGVPrinter print = new DGVPrinter();
            print.Title = "Transações Mensal"; //Titulo da Página
            print.SubTitle = String.Format("Data de geração: {0}", DateTime.Today.ToString("dd/MM/yyyy"));
            print.PageSettings.Landscape = true;
            print.PorportionalColumns = true;
            print.PageNumberInHeader = false;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "BitXchange";


            print.PrintDataGridView(dgvListarTransacoes);
        }

        private void dtDataFinal_CloseUp(object sender, EventArgs e)
        {
            LimparVariaveis();
            CarregarGrid();            
        }
    }
}