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
    }
}
