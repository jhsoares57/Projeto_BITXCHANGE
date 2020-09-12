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
    }
}
