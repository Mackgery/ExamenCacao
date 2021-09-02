using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login1
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            frmproductos frmp = new frmproductos();
            frmp.Visible = true;
            this.Visible = false;
        }

        private void btnClie_Click(object sender, EventArgs e)
        {
            frmclientes frmc = new frmclientes();
            frmc.Visible = true;
            this.Visible = false;
        }

        private void btnCiu_Click(object sender, EventArgs e)
        {
            frmciudades frmci = new frmciudades();
            frmci.Visible = true;
            this.Visible = false;
        }
    }
}
