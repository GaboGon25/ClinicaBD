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
    public partial class frmPagos : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ClinicaBD"].ConnectionString;
        public frmPagos()
        {
            InitializeComponent();
        }

        private void CargarPacientes()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"
                        SELECT DISTINCT 
                            P.PacienteID, 
                            P.Nombre + ' ' + P.Apellido AS NombreCompleto
                        FROM Paciente P
                        INNER JOIN Citas C ON P.PacienteID = C.PacienteID
                        WHERE C.Estado = 1";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbPacientes.DisplayMember = "NombreCompleto";
                    cmbPacientes.ValueMember = "PacienteID";
                    cmbPacientes.DataSource = dt;
                    cmbPacientes.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pacientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosPaciente(int pacienteID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"
                SELECT TOP 1 
                    P.Nombre, 
                    P.Apellido, 
                    C.Fecha, 
                    STRING_AGG(PR.Titulo, ', ') AS Procedimientos,
                    SUM(ISNULL(CP.Costo_Procedimiento, PR.Costo)) AS Total
                FROM Paciente P
                INNER JOIN Citas C ON P.PacienteID = C.PacienteID
                INNER JOIN Citas_Procedimientos CP ON C.CitaID = CP.CitaID
                INNER JOIN Procedimientos PR ON CP.ProcedimientoID = PR.ProcedimientoID
                WHERE P.PacienteID = @PacienteID AND C.Estado = 1
                GROUP BY P.Nombre, P.Apellido, C.Fecha";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@PacienteID", pacienteID);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtNombrePaciente.Text = reader["Nombre"].ToString();
                        txtApellidoPaciente.Text = reader["Apellido"].ToString();
                        dtpFechaCita.Text = Convert.ToDateTime(reader["Fecha"]).ToShortDateString();
                        txtProcedimientos.Text = reader["Procedimientos"].ToString();
                        txtTotal.Text = Convert.ToString(reader["Total"]);
                    }
                    else
                    {
                        MessageBox.Show("El paciente no tiene cita asociada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar datos del paciente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPagos()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                  SELECT 
                CP.CitasProcedimientosID,
                P.Nombre AS Nombre,
                P.Apellido AS Apellido,
                Pago.Fecha AS FechaPago,
                STUFF(
                    (SELECT ', ' + Proce.Titulo
                     FROM Citas_Procedimientos CP
                     INNER JOIN Procedimientos Proce ON CP.ProcedimientoID = Proce.ProcedimientoID
                     WHERE CP.CitaID = C.CitaID
                     FOR XML PATH('')), 1, 2, '') AS Procedimientos,
                Pago.Total AS TotalPagado
            FROM Pago
            INNER JOIN Citas_Procedimientos CP ON Pago.CitasProcedimientosID = CP.CitasProcedimientosID
            INNER JOIN Citas C ON CP.CitaID = C.CitaID
            INNER JOIN Paciente P ON C.PacienteID = P.PacienteID";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvPago.DataSource = dt;

                    // Ocultar columnas innecesarias
                    dgvPago.Columns["CitasProcedimientosID"].Visible = false;
                    //dgvPago.Columns["CitaID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error al cargar los pagos: {ex.Message}\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Error al cargar los pagos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void frmPagos_Load(object sender, EventArgs e)
        {
            CargarPacientes();
            CargarPagos();
            LimpiarCampos(); 
            cmbPacientes.SelectedIndex = -1;
        }

        private void cmbPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPacientes.SelectedValue != null)
            {
                CargarDatosPaciente((int)cmbPacientes.SelectedValue);
            }
        }

        private void rbtnSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSi.Checked)
            {
                txtTotalDescuento.Enabled = true;
                txtTotal.Enabled = false;
            }
        }

        private void rbtnNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNo.Checked)
            {
                txtTotalDescuento.Enabled = false;
                txtTotal.Enabled = true;
            }
        }

        private void LimpiarCampos()
        {
            txtNombrePaciente.Clear();
            txtApellidoPaciente.Clear();
            dtpFechaCita.Value = DateTime.Now;
            txtProcedimientos.Clear();
            txtTotal.Clear();
            txtTotalDescuento.Clear();
            rbtnSi.Checked = false;
            rbtnNo.Checked = false;
            txtTotal.Enabled = true;
            txtTotalDescuento.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    int pacienteID = Convert.ToInt32(cmbPacientes.SelectedValue);
                    decimal totalPagar;
                    bool descuento = rbtnSi.Checked;

                    if (descuento)
                    {
                        // Validación del monto con descuento
                        if (string.IsNullOrWhiteSpace(txtTotalDescuento.Text) ||
                            !decimal.TryParse(txtTotalDescuento.Text, out totalPagar) ||
                            totalPagar <= 0)
                        {
                            MessageBox.Show("Ingrese un monto válido para el descuento mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Inserción directa del pago con descuento
                        string queryPagoConDescuento = @"
                INSERT INTO Pago (CitasProcedimientosID, Fecha, Total)
                SELECT 
                    MIN(CP.CitasProcedimientosID), 
                    GETDATE(), 
                    @TotalDescuento
                FROM Citas_Procedimientos CP
                INNER JOIN Citas C ON CP.CitaID = C.CitaID
                WHERE C.PacienteID = @PacienteID AND C.Estado = 1
                GROUP BY C.CitaID";

                        SqlCommand cmdPagoConDescuento = new SqlCommand(queryPagoConDescuento, con);
                        cmdPagoConDescuento.Parameters.AddWithValue("@TotalDescuento", totalPagar);
                        cmdPagoConDescuento.Parameters.AddWithValue("@PacienteID", pacienteID);

                        int filasInsertadas = cmdPagoConDescuento.ExecuteNonQuery();

                        if (filasInsertadas == 0)
                        {
                            MessageBox.Show("No se pudo registrar el pago con descuento. Verifica los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        // Inserción del pago calculado automáticamente sin descuento
                        string queryPagoSinDescuento = @"
                INSERT INTO Pago (CitasProcedimientosID, Fecha, Total)
                SELECT 
                    MIN(CP.CitasProcedimientosID), 
                    GETDATE(), 
                    SUM(ISNULL(CP.Costo_Procedimiento, PR.Costo))
                FROM Citas_Procedimientos CP
                INNER JOIN Citas C ON CP.CitaID = C.CitaID
                INNER JOIN Procedimientos PR ON CP.ProcedimientoID = PR.ProcedimientoID
                WHERE C.PacienteID = @PacienteID AND C.Estado = 1
                GROUP BY C.CitaID";

                        SqlCommand cmdPagoSinDescuento = new SqlCommand(queryPagoSinDescuento, con);
                        cmdPagoSinDescuento.Parameters.AddWithValue("@PacienteID", pacienteID);

                        int filasInsertadas = cmdPagoSinDescuento.ExecuteNonQuery();

                        if (filasInsertadas == 0)
                        {
                            MessageBox.Show("No se pudo registrar el pago. Verifica los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Actualiza el estado de las citas asociadas
                    string queryActualizarCita = @"
            UPDATE Citas
            SET Estado = 0
            WHERE PacienteID = @PacienteID AND Estado = 1";

                    SqlCommand cmdActualizarCita = new SqlCommand(queryActualizarCita, con);
                    cmdActualizarCita.Parameters.AddWithValue("@PacienteID", pacienteID);
                    cmdActualizarCita.ExecuteNonQuery();

                    // Refrescar datos en la interfaz
                    CargarPagos();
                    CargarPacientes();
                    MessageBox.Show("Pago registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) 
                {
                    DataGridViewRow row = dgvPago.Rows[e.RowIndex];

                    txtNombrePaciente.Text = row.Cells["Nombre"].Value.ToString();
                    txtApellidoPaciente.Text = row.Cells["Apellido"].Value.ToString();
                    dtpFechaCita.Value = Convert.ToDateTime(row.Cells["FechaPago"].Value);
                    txtProcedimientos.Text = row.Cells["Procedimientos"].Value.ToString();
                    txtTotal.Text = row.Cells["TotalPagado"].Value.ToString();

                    // Habilitar o deshabilitar campos según descuento
                    rbtnSi.Checked = false;
                    rbtnNo.Checked = false;
                    txtTotalDescuento.Text = "";
                    txtTotal.Enabled = true;
                    txtTotalDescuento.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombrePaciente.Text) || string.IsNullOrWhiteSpace(txtApellidoPaciente.Text))
                {
                    MessageBox.Show("Seleccione un paciente desde el listado para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea actualizar los datos del paciente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.No)
                {
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    int filaSeleccionada = dgvPago.CurrentCell.RowIndex;
                    int citaProcedimientoID = Convert.ToInt32(dgvPago.Rows[filaSeleccionada].Cells["CitasProcedimientosID"].Value);

                    decimal totalPagar;
                    bool descuento = rbtnSi.Checked;

                    if (descuento)
                    {
                        if (string.IsNullOrWhiteSpace(txtTotalDescuento.Text) || !decimal.TryParse(txtTotalDescuento.Text, out totalPagar))
                        {
                            MessageBox.Show("Ingrese un monto válido para el descuento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        if (!decimal.TryParse(txtTotal.Text, out totalPagar))
                        {
                            MessageBox.Show("El monto total no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string queryActualizarPago = @"
                    UPDATE Pago
                    SET Total = @Total, Fecha = GETDATE()
                    WHERE CitasProcedimientosID = @CitasProcedimientosID";

                    SqlCommand cmdActualizarPago = new SqlCommand(queryActualizarPago, con);
                    cmdActualizarPago.Parameters.AddWithValue("@Total", totalPagar);
                    cmdActualizarPago.Parameters.AddWithValue("@CitasProcedimientosID", citaProcedimientoID);
                    cmdActualizarPago.ExecuteNonQuery();

                    dgvPago.Rows[filaSeleccionada].Cells["TotalPagado"].Value = totalPagar;
                    dgvPago.Rows[filaSeleccionada].Cells["FechaPago"].Value = DateTime.Now;

                    MessageBox.Show("Datos del paciente actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
