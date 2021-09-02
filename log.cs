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
    public partial class log : Form
    {
        public log()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string usuario = txtCorr.Text;
            string password = txtPassword.Text;

            try
            {
                Controlador ctrl = new Controlador();
                string respuesta = ctrl.ctrllogin(usuario, password);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frmprincipal frm = new frmprincipal();
                    frm.Visible = true;
                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            frmRegistro frmr = new frmRegistro();
            frmr.Visible = true;
            this.Visible = false;
        }
    }
}
