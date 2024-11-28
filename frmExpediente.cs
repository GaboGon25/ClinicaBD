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
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ClinicaBD
{
    public partial class frmExpediente : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ClinicaBD"].ConnectionString;

        private int pacienteIDSeleccionado;
        public frmExpediente()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistrosPacientes frmRegistrosPacientes = new frmRegistrosPacientes();
            frmRegistrosPacientes.Owner = this;
            frmRegistrosPacientes.ShowDialog();
        }

        public void SetPacienteSeleccionado(int pacienteID, string? nombre, string? apellido)
        {
            txtNombrePaciente.Text = nombre;
            txtApellidoPaciente.Text = apellido;
            this.pacienteIDSeleccionado = pacienteID;

            // Deshabilitar los campos para evitar ediciones
            txtNombrePaciente.ReadOnly = true;
            txtApellidoPaciente.ReadOnly = true;
        }

        private void CargarBiotipoCutaneo()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT BiotipoCutaneoID, Tipo FROM Biotipo_Cutaneo";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbBiotipoCutaneo.DisplayMember = "Tipo";
                    cmbBiotipoCutaneo.ValueMember = "BiotipoCutaneoID";
                    cmbBiotipoCutaneo.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar biotipo cutaneo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmExpediente_Load(object sender, EventArgs e)
        {
            CargarBiotipoCutaneo();
            ActualizarDataGridView();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtHistorialMedico.Text))
            {
                MessageBox.Show("El historial médico es obligatorio.");
                return false;
            }

            if (cmbBiotipoCutaneo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un biotipo cutáneo.");
                return false;
            }

            if (!radioButtonSi.Checked && !radioButtonNo.Checked)
            {
                MessageBox.Show("Debe seleccionar si usa marcapasos o no.");
                return false;
            }

            // Verificar que al menos un cuidado de piel esté seleccionado
            if (!checkBoxJabonFacial.Checked && !checkBoxCremas.Checked && !checkBoxSerum.Checked &&
                !checkBoxAceites.Checked && !checkBoxTonico.Checked && !checkBoxProtectorSolar.Checked &&
                !checkBoxNinguno.Checked)
            {
                MessageBox.Show("Debe seleccionar al menos un cuidado de piel.");
                return false;
            }

            return true;
        }

        private void GuardarExpediente()
        {
            if (!ValidarCampos())
                return;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Insertar en la tabla Expediente
                    SqlCommand cmdExpediente = new SqlCommand(
                        "INSERT INTO Expediente (Historial_Medico, UsoMarcapasos, PacienteID, BiotipoCutaneoID) " +
                        "VALUES (@HistorialMedico, @UsoMarcapasos, @PacienteID, @BiotipoCutaneoID); SELECT SCOPE_IDENTITY();",
                        connection, transaction);

                    cmdExpediente.Parameters.AddWithValue("@HistorialMedico", txtHistorialMedico.Text);
                    cmdExpediente.Parameters.AddWithValue("@UsoMarcapasos", radioButtonSi.Checked ? 1 : 0);
                    cmdExpediente.Parameters.AddWithValue("@PacienteID", pacienteIDSeleccionado); // Obtenido del DataGridView
                    cmdExpediente.Parameters.AddWithValue("@BiotipoCutaneoID", cmbBiotipoCutaneo.SelectedValue);

                    int expedienteID = Convert.ToInt32(cmdExpediente.ExecuteScalar());

                    // Insertar en la tabla Habitos_Expediente
                    GuardarHabitos(connection, transaction, expedienteID);

                    // Insertar en la tabla CuidadoPiel_Expediente
                    GuardarCuidadosPiel(connection, transaction, expedienteID);

                    // Confirmar transacción
                    transaction.Commit();

                    MessageBox.Show("Expediente guardado correctamente.");
                    ActualizarDataGridView();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error al guardar el expediente: {ex.Message}");
                }
            }
        }

        private void ActualizarDataGridView()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                     SELECT 
                    e.ExpedienteID,
                    p.Nombre + ' ' + p.Apellido AS Paciente,
                    e.Historial_Medico AS HistorialMedico,
                    bc.Tipo AS BiotipoCutaneo,
                    CASE e.UsoMarcapasos WHEN 1 THEN 'Sí' ELSE 'No' END AS UsoMarcapasos,
                    STRING_AGG(h.Nombre + ': ' + he.Descripcion, ', ') AS Habitos,
                    STRING_AGG(cp.Tipo, ', ') AS CuidadosPiel
                    FROM Expediente e
                    INNER JOIN Paciente p ON e.PacienteID = p.PacienteID
                    INNER JOIN Biotipo_Cutaneo bc ON e.BiotipoCutaneoID = bc.BiotipoCutaneoID
                    LEFT JOIN Habitos_Expediente he ON e.ExpedienteID = he.ExpedienteID
                    LEFT JOIN Habitos h ON he.HabitosID = h.HabitosID
                    LEFT JOIN CuidadoPiel_Expediente cpe ON e.ExpedienteID = cpe.ExpedienteID
                    LEFT JOIN Cuidados_Piel cp ON cpe.CuidadosPielID = cp.CuidadosPielID
                    GROUP BY e.ExpedienteID, p.Nombre, p.Apellido, e.Historial_Medico, bc.Tipo, e.UsoMarcapasos";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvExpediente.DataSource = dt;

                    // Ocultar la columna ExpedienteID
                    if (dgvExpediente.Columns.Contains("ExpedienteID"))
                    {
                        dgvExpediente.Columns["ExpedienteID"].Visible = false;
                    }

                    // Ajustar columnas automáticamente al contenido
                    dgvExpediente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                    // Opcional: Alinear texto de las columnas al centro (si deseas mejorar la estética)
                    foreach (DataGridViewColumn column in dgvExpediente.Columns)
                    {
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos del expediente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarCuidadosPiel(SqlConnection connection, SqlTransaction transaction, int expedienteID)
        {
            CheckBox[] cuidados = {
                checkBoxJabonFacial, checkBoxCremas, checkBoxSerum,
                checkBoxAceites, checkBoxTonico, checkBoxProtectorSolar, checkBoxNinguno
            };

            for (int i = 0; i < cuidados.Length; i++)
            {
                if (cuidados[i].Checked)
                {
                    SqlCommand cmdCuidadosPiel = new SqlCommand(
                        "INSERT INTO CuidadoPiel_Expediente (ExpedienteID, CuidadosPielID) VALUES (@ExpedienteID, @CuidadosPielID)",
                        connection, transaction);

                    cmdCuidadosPiel.Parameters.AddWithValue("@ExpedienteID", expedienteID);
                    cmdCuidadosPiel.Parameters.AddWithValue("@CuidadosPielID", i + 1); // IDs de Cuidados_Piel predefinidos

                    cmdCuidadosPiel.ExecuteNonQuery();
                }
            }
        }

        private void GuardarHabitos(SqlConnection connection, SqlTransaction transaction, int expedienteID)
        {
            string[] habitos = {
                txtVasosAgua.Text,
                txtConsumoTabaco.Text,
                txtConsumoMedicamento.Text,
                txtTrasnoche.Text,
                txtConsumoCafe.Text,
                txtConsumoSuplementos.Text,
                txtConsumoLicor.Text
            };

            for (int i = 0; i < habitos.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(habitos[i]))
                {
                    SqlCommand cmdHabitos = new SqlCommand(
                        "INSERT INTO Habitos_Expediente (ExpedienteID, HabitosID, Descripcion) VALUES (@ExpedienteID, @HabitosID, @Descripcion)",
                        connection, transaction);

                    cmdHabitos.Parameters.AddWithValue("@ExpedienteID", expedienteID);
                    cmdHabitos.Parameters.AddWithValue("@HabitosID", i + 1); // IDs de Habitos predefinidos
                    cmdHabitos.Parameters.AddWithValue("@Descripcion", habitos[i]);

                    cmdHabitos.ExecuteNonQuery();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            GuardarExpediente();
        }
    }
}
