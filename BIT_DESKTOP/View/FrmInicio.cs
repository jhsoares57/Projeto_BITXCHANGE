using BLL;
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
    public partial class FrmInicio : MaterialForm
    {
        TransacaoBLL TransBLL = new TransacaoBLL();
        CotacaoBLL CotBLL = new CotacaoBLL();


        public static decimal total;
        public static string moeda;
        public static decimal bit;
        public static decimal real;
        public static decimal etherum;
        public static decimal dolar;


        public FrmInicio()
        {
            InitializeComponent();

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


        public void CarregarGrid()
        {
            dgvUltimasTransacoes.DataSource = TransBLL.ListarUltimasTransacoes();

        }

        private void CarregarCotacao()
        {
          

            dgvmoeda.DataSource = CotBLL.ListarCotacaoMoedaBLL();
            CarregarCard();
        }

        private void CarregarCard()
        {
            foreach (DataGridViewRow linha in dgvmoeda.Rows)
            {
                string moeda = Convert.ToString(linha.Cells[1].Value);
                if (moeda == "1")
                {
                    bit += Convert.ToDecimal(linha.Cells[0].Value);

                    lblBit.Text = Convert.ToString(bit);
                }
                if (moeda == "2")
                {

                    real += Convert.ToDecimal(linha.Cells[0].Value);

                    lblReal.Text = Convert.ToString(real);
                }
                if (moeda == "3")
                {

                    etherum += Convert.ToDecimal(linha.Cells[0].Value);

                    lblEthe.Text = Convert.ToString(etherum);
                }
                if (moeda == "4")
                {

                    dolar += Convert.ToDecimal(linha.Cells[0].Value);

                    lblDolar.Text = Convert.ToString(dolar);
                }

            }
        }

        public void NomeUser(string user)
        {
            string nome = user;
            lblNomeUser.Text = nome +" !";
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregarCotacao();
            
        }
    }
}
