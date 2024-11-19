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
    public partial class frmCentral : Form
    {
        public frmCentral()
        {
            InitializeComponent();
        }

        private void pnlSideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlLetrero_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCentral_Load(object sender, EventArgs e)
        {

        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void pbxOcultar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbxMinimizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            //pbxRestauar.Visible = false;
            //pbxMinimizar.Visible = true;

            this.WindowState = FormWindowState.Maximized;
            pbxMinimizar.Visible = false;
            pbxRestauar.Visible = true;
        }

        private void pbxRestauar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            //pbxMinimizar.Visible = false;
            //pbxRestauar.Visible = true;

            this.WindowState = FormWindowState.Normal;
            pbxRestauar.Visible = false;
            pbxMinimizar.Visible = true;
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

        //private void btnPaciente_Click(object sender, EventArgs e)
        //{
        //    AbrirFormPanel(new frmPaciente());
        //}

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmPaciente());
        }

        private void btnExpediente_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmExpediente());
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmCitas());
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmPagos());
        }
    }
}
