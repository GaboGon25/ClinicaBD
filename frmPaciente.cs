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
    public partial class frmPaciente : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ClinicaBD"].ConnectionString;
        public frmPaciente()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmOcupaciones frmOcupaciones = new frmOcupaciones();
            frmOcupaciones.ShowDialog();
            CargarOcupaciones();
        }

        private void CargarOcupaciones()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT OcupacionID, Nombre FROM Ocupacion";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbOcupacion.DisplayMember = "Nombre";
                    cmbOcupacion.ValueMember = "OcupacionID";
                    cmbOcupacion.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ocupaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPacientes()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"SELECT 
                                Paciente.PacienteID,
                                Paciente.Nombre,
                                Paciente.Apellido,
                                Paciente.Fecha_Nacimiento,
                                Paciente.Telefono,
                                Paciente.Correo,
                                Paciente.Direccion,
                                Ocupacion.OcupacionID,
                                Ocupacion.Nombre AS OcupacionNombre
                             FROM Paciente
                             INNER JOIN Ocupacion ON Paciente.OcupacionID = Ocupacion.OcupacionID";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvPacientes.DataSource = dt;
                    dgvPacientes.Columns["PacienteID"].Visible = false;
                    dgvPacientes.Columns["OcupacionID"].Visible = false;
                    dgvPacientes.Columns["OcupacionNombre"].HeaderText = "Ocupación";

                    // Esto reordena las columnas para que la ocupacion no aparezca de ultimo
                    dgvPacientes.Columns["Nombre"].DisplayIndex = 0; 
                    dgvPacientes.Columns["Apellido"].DisplayIndex = 1; 
                    dgvPacientes.Columns["OcupacionNombre"].DisplayIndex = 2; 
                    dgvPacientes.Columns["Fecha_Nacimiento"].DisplayIndex = 3;
                    dgvPacientes.Columns["Telefono"].DisplayIndex = 4;
                    dgvPacientes.Columns["Correo"].DisplayIndex = 5;
                    dgvPacientes.Columns["Direccion"].DisplayIndex = 6;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pacientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtNombreP.Clear();
            txtApellidoP.Clear();
            cmbOcupacion.SelectedIndex = -1;
            txtCelular.Clear();
            txtDireccion.Clear();
            dtpFechaNacimiento.Value = DateTime.Now;
            txtPacienteID.Clear();
            txtCorreo.Clear();
        }

        private void frmPaciente_Load_1(object sender, EventArgs e)
        {
            CargarPacientes();
            CargarOcupaciones();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos obligatorios
                if (string.IsNullOrWhiteSpace(txtNombreP.Text) ||
                    string.IsNullOrWhiteSpace(txtApellidoP.Text) ||
                    cmbOcupacion.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txtCelular.Text) ||
                    string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios. Por favor, complete la información.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Paciente (OcupacionID, Nombre, Apellido, Fecha_Nacimiento, Telefono, Correo, Direccion) " +
                                   "VALUES (@OcupacionID, @Nombre, @Apellido, @FechaNacimiento, @Telefono, @Correo, @Direccion)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    // Asignar valores desde los controles
                    cmd.Parameters.AddWithValue("@OcupacionID", (cmbOcupacion.SelectedItem as DataRowView)["OcupacionID"]); //ojoaqui
                    cmd.Parameters.AddWithValue("@Nombre", txtNombreP.Text.Trim());
                    cmd.Parameters.AddWithValue("@Apellido", txtApellidoP.Text.Trim());
                    cmd.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value);
                    cmd.Parameters.AddWithValue("@Telefono", txtCelular.Text.Trim());
                    cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text.Trim());
                    cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text.Trim());

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Paciente agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarPacientes();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el paciente. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar el paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPacienteID.Text))
                {
                    MessageBox.Show("Seleccione un paciente para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Mostrar cuadro de confirmación
                DialogResult result = MessageBox.Show("¿Está seguro de que desea guardar los cambios?", "Confirmación",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = @"UPDATE Paciente 
                                 SET OcupacionID = @OcupacionID, 
                                     Nombre = @Nombre, 
                                     Apellido = @Apellido, 
                                     Fecha_Nacimiento = @FechaNacimiento, 
                                     Telefono = @Telefono, 
                                     Correo = @Correo, 
                                     Direccion = @Direccion 
                                 WHERE PacienteID = @PacienteID";
                        SqlCommand cmd = new SqlCommand(query, con);


                        cmd.Parameters.AddWithValue("@OcupacionID", (cmbOcupacion.SelectedItem as DataRowView)["OcupacionID"]);
                        cmd.Parameters.AddWithValue("@Nombre", txtNombreP.Text.Trim());
                        cmd.Parameters.AddWithValue("@Apellido", txtApellidoP.Text.Trim());
                        cmd.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value);
                        cmd.Parameters.AddWithValue("@Telefono", txtCelular.Text.Trim());
                        cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text.Trim());
                        cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text.Trim());
                        cmd.Parameters.AddWithValue("@PacienteID", txtPacienteID.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Paciente actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarPacientes(); // esto es para refrescar el DataGridView
                            LimpiarCampos(); // y esto para limpiar controles
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPacientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPacientes.Rows[e.RowIndex];

                txtNombreP.Text = row.Cells["Nombre"].Value.ToString();
                txtApellidoP.Text = row.Cells["Apellido"].Value.ToString();
                cmbOcupacion.SelectedValue = row.Cells["OcupacionID"].Value;
                dtpFechaNacimiento.Value = Convert.ToDateTime(row.Cells["Fecha_Nacimiento"].Value);
                txtCelular.Text = row.Cells["Telefono"].Value.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                txtCorreo.Text = row.Cells["Correo"].Value.ToString();
                txtPacienteID.Text = row.Cells["PacienteID"].Value.ToString();
            }
        }
    }
}
