using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            this.WindowState = FormWindowState.Maximized;
            pbxMinimizar.Visible = false;
            pbxRestauar.Visible = true;
        }

        private void pbxRestauar_Click(object sender, EventArgs e)
        {
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

        // Metodo para mover el formulario con el panel
        private void frmletrero_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

            }
        }

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmHora());
        }

        private void frmCentral_Load(object sender, EventArgs e)
        {
            pictureBox1_Click(null, e);
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmIngresos());
        }
    }
}
