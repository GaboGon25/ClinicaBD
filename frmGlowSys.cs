using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaBD
{
    public partial class frmGlowSys : Form
    {
        public frmGlowSys()
        {
            InitializeComponent();
        }

        private void frmGlowSys_Load(object sender, EventArgs e)
        {

        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pbMaximizar.Visible = false;
            pbRestaurar.Visible = true;
        }

        private void pbRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pbRestaurar.Visible = false;
            pbMaximizar.Visible = true;
        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AbrirFormPanel(Object formPanel)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            Form fp = formPanel as Form;
            fp.TopLevel = false;
            fp.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fp);
            this.pnlContenedor.Tag = fp;
            fp.Show();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmPacientes());
        }
    }
}
