using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaBD
{
    public partial class frmRegistrosPacientes : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ClinicaBD"].ConnectionString;
        public frmRegistrosPacientes()
        {
            InitializeComponent();
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLetrero_MouseDown(object sender, MouseEventArgs e)
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

        private void CargarPacientes()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT p.PacienteID, p.Nombre, p.Apellido FROM Paciente p LEFT JOIN Expediente e ON p.PacienteID = e.PacienteID WHERE e.PacienteID IS NULL";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPacientes.DataSource = dt;
                dgvPacientes.Columns["PacienteID"].Visible = false;
            }
        }

        private void frmRegistrosPacientes_Load(object sender, EventArgs e)
        {
            CargarPacientes();
        }
        private void dgvPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                int pacienteID = Convert.ToInt32(dgvPacientes.Rows[e.RowIndex].Cells["PacienteID"].Value);
                string nombre = dgvPacientes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                string apellido = dgvPacientes.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();

                if (this.Owner is frmExpediente formExpediente)
                {
                    formExpediente.SetPacienteSeleccionado(pacienteID,nombre, apellido);
                }
                this.Close();
            }
        }
    }
}
