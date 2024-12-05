using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaBD
{
    public partial class frmCitasProgramadas : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ClinicaBD"].ConnectionString;
        public frmCitasProgramadas()
        {
            InitializeComponent();
        }

        private void CargarCitasProgramadas()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // Consulta solo para citas activas
                    string query = @"
            SELECT 
                c.CitaID,
                p.Nombre + ' ' + p.Apellido AS Paciente,
                c.Fecha,
                c.Hora,
                c.Motivo_Cita,
                'Activo' AS Estado
            FROM Citas c
            INNER JOIN Paciente p ON c.PacienteID = p.PacienteID
            WHERE c.Estado = 1
            ORDER BY c.Fecha ASC, c.Hora ASC";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvCitasProgramadas.DataSource = dt;
                    dgvCitasProgramadas.Columns["CitaID"].Visible = false;
                    dgvCitasProgramadas.Columns["Estado"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar citas programadas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCitasProgramadas_Load(object sender, EventArgs e)
        {
            CargarCitasProgramadas();
        }

        private void BuscarCitas()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // Base query con filtro de citas activas
                    string query = @"
            SELECT 
                c.CitaID,
                p.Nombre + ' ' + p.Apellido AS Paciente,
                c.Fecha,
                c.Hora,
                c.Motivo_Cita,
                CASE 
                    WHEN c.Estado = 1 THEN 'Activo'
                    ELSE 'Inactivo'
                END AS Estado
            FROM Citas c
            INNER JOIN Paciente p ON c.PacienteID = p.PacienteID
            WHERE c.Estado = 1 ";

                    // Condiciones dinámicas según filtros
                    if (!string.IsNullOrWhiteSpace(txtBuscarNombre.Text))
                    {
                        query += "AND (p.Nombre + ' ' + p.Apellido) LIKE @Nombre ";
                    }

                    if (dtpBuscarFecha.Checked)
                    {
                        query += "AND c.Fecha = @Fecha ";
                    }

                    query += "ORDER BY c.Fecha ASC, c.Hora ASC";

                    SqlCommand cmd = new SqlCommand(query, con);
                    if (!string.IsNullOrWhiteSpace(txtBuscarNombre.Text))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", "%" + txtBuscarNombre.Text + "%");
                    }

                    if (dtpBuscarFecha.Checked)
                    {
                        cmd.Parameters.AddWithValue("@Fecha", dtpBuscarFecha.Value.Date);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvCitasProgramadas.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar citas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RestaurarVista()
        {
            // Limpia las entradas y recarga todas las citas programadas
            txtBuscarNombre.Clear();
            dtpBuscarFecha.Value = DateTime.Now;
            dtpBuscarFecha.Checked = false;
            CargarCitasProgramadas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCitas();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            RestaurarVista();
        }
    }
}
