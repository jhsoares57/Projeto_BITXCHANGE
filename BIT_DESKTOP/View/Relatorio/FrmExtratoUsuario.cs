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

namespace BIT_DESKTOP.View.Relatorio
{
    public partial class FrmExtratoUsuario : MaterialForm
    {

        TransacaoBLL transacao = new TransacaoBLL();

        private Form f;

        public Form F { get => f; set => f = value; }

        public static string moeda;
        public static decimal bit;
        public static decimal real;
        public static decimal etherum;
        public static decimal dolar;

        public FrmExtratoUsuario()
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


        public void CarregarIdUsuario(int id, string nome)
        {
           dgvExtrato.DataSource = transacao.ListarExtratoUserBLL(id);
            lblNomeUser.Text = nome;
            

        }

        private void carregarTotalMoeda()
        {
          
            foreach (DataGridViewRow linha in dgvExtrato.Rows)
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmExtratoUsuario_Load(object sender, EventArgs e)
        {
            carregarTotalMoeda();
        }

        private void dgvExtrato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime data = Convert.ToDateTime(dgvExtrato.Rows[e.RowIndex].Cells[0].Value.ToString());
            lblData.Text = data.ToString("dd/MM/yyyy");
            lblProtocolo.Text = dgvExtrato.Rows[e.RowIndex].Cells[1].Value.ToString();
            lblTipotransacao.Text = dgvExtrato.Rows[e.RowIndex].Cells[2].Value.ToString();
            lblMoeda.Text = dgvExtrato.Rows[e.RowIndex].Cells[4].Value.ToString();
            lblValor.Text = dgvExtrato.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
