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
        private int expedienteID; // Variable de clase para almacenar el ExpedienteID
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

                // Limpia la fuente de datos para evitar duplicados
                dgvExpediente.DataSource = null;
                dgvExpediente.Rows.Clear();

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
    -- Subconsulta para obtener hábitos únicos
    (SELECT STRING_AGG(h.Nombre + ': ' + he.Descripcion, ', ')
     FROM Habitos_Expediente he
     INNER JOIN Habitos h ON he.HabitosID = h.HabitosID
     WHERE he.ExpedienteID = e.ExpedienteID) AS Habitos,
    -- Subconsulta para obtener cuidados de piel únicos
    (SELECT STRING_AGG(cp.Tipo, ', ')
     FROM CuidadoPiel_Expediente cpe
     INNER JOIN Cuidados_Piel cp ON cpe.CuidadosPielID = cp.CuidadosPielID
     WHERE cpe.ExpedienteID = e.ExpedienteID) AS CuidadosPiel
FROM Expediente e
INNER JOIN Paciente p ON e.PacienteID = p.PacienteID
INNER JOIN Biotipo_Cutaneo bc ON e.BiotipoCutaneoID = bc.BiotipoCutaneoID";

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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                // Asegúrate de que se haya seleccionado un expediente y que el TextBox no esté vacío
                if (string.IsNullOrWhiteSpace(txtExpedienteID.Text) || int.TryParse(txtExpedienteID.Text, out int expedienteID) == false)
                {
                    MessageBox.Show("Por favor, selecciona un expediente para editar.");
                    return;
                }

                // Inicia la conexión y la transacción
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        // Actualizar los valores del expediente
                        SqlCommand cmdActualizarExpediente = new SqlCommand(
                            "UPDATE Expediente SET Historial_Medico = @Historial_Medico, UsoMarcapasos = @UsoMarcapasos " +
                            "WHERE ExpedienteID = @ExpedienteID", connection, transaction);
                        cmdActualizarExpediente.Parameters.AddWithValue("@Historial_Medico", txtHistorialMedico.Text);
                        cmdActualizarExpediente.Parameters.AddWithValue("@UsoMarcapasos", radioButtonSi.Checked ? 1 : 0);
                        cmdActualizarExpediente.Parameters.AddWithValue("@ExpedienteID", expedienteID);
                        cmdActualizarExpediente.ExecuteNonQuery();

                        // Actualizar los hábitos
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
                                SqlCommand cmdActualizarHabitos = new SqlCommand(
                                    "IF EXISTS (SELECT 1 FROM Habitos_Expediente WHERE ExpedienteID = @ExpedienteID AND HabitosID = @HabitosID) " +
                                    "UPDATE Habitos_Expediente SET Descripcion = @Descripcion WHERE ExpedienteID = @ExpedienteID AND HabitosID = @HabitosID " +
                                    "ELSE " +
                                    "INSERT INTO Habitos_Expediente (ExpedienteID, HabitosID, Descripcion) VALUES (@ExpedienteID, @HabitosID, @Descripcion)",
                                    connection, transaction);

                                cmdActualizarHabitos.Parameters.AddWithValue("@ExpedienteID", expedienteID);
                                cmdActualizarHabitos.Parameters.AddWithValue("@HabitosID", i + 1); // IDs de hábitos predefinidos
                                cmdActualizarHabitos.Parameters.AddWithValue("@Descripcion", habitos[i]);

                                cmdActualizarHabitos.ExecuteNonQuery();
                            }
                        }

                        // Actualizar los cuidados de piel
                        CheckBox[] cuidados = {
            checkBoxJabonFacial, checkBoxCremas, checkBoxSerum,
            checkBoxAceites, checkBoxTonico, checkBoxProtectorSolar, checkBoxNinguno
        };

                        try
                        {
                            // Eliminar los registros anteriores de cuidados de piel para el expediente
                            SqlCommand cmdEliminarCuidados = new SqlCommand(
                                "DELETE FROM CuidadoPiel_Expediente WHERE ExpedienteID = @ExpedienteID", connection, transaction);
                            cmdEliminarCuidados.Parameters.AddWithValue("@ExpedienteID", expedienteID);
                            cmdEliminarCuidados.ExecuteNonQuery();

                            // Insertar los nuevos cuidados de piel seleccionados
                            for (int i = 0; i < cuidados.Length; i++)
                            {
                                if (cuidados[i].Checked)
                                {
                                    // Insertar solo los cuidados seleccionados
                                    SqlCommand cmdActualizarCuidadosPiel = new SqlCommand(
                                        "IF NOT EXISTS (SELECT 1 FROM CuidadoPiel_Expediente WHERE ExpedienteID = @ExpedienteID AND CuidadosPielID = @CuidadosPielID) " +
                                        "INSERT INTO CuidadoPiel_Expediente (ExpedienteID, CuidadosPielID) VALUES (@ExpedienteID, @CuidadosPielID)",
                                        connection, transaction);

                                    cmdActualizarCuidadosPiel.Parameters.AddWithValue("@ExpedienteID", expedienteID);
                                    cmdActualizarCuidadosPiel.Parameters.AddWithValue("@CuidadosPielID", i + 1); // IDs de cuidados predefinidos

                                    cmdActualizarCuidadosPiel.ExecuteNonQuery();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al actualizar los cuidados de piel: " + ex.Message);
                            transaction.Rollback();
                            return;
                        }

                        // Si todo fue bien, confirma la transacción
                        transaction.Commit();
                        ActualizarDataGridView();
                        MessageBox.Show("Expediente actualizado exitosamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el expediente: " + ex.Message);
            }

        }

        private void dgvExpediente_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvExpediente.Rows[e.RowIndex];

                txtExpedienteID.Text = row.Cells["ExpedienteID"].Value.ToString();

                //// Asignamos el ExpedienteID a la variable
                //expedienteID = Convert.ToInt32(row.Cells["ExpedienteID"].Value);  // Aquí obtenemos el ID de la fila seleccionada


                txtHistorialMedico.Text = row.Cells["HistorialMedico"].Value?.ToString();
                radioButtonSi.Checked = row.Cells["UsoMarcapasos"].Value?.ToString() == "Sí";
                radioButtonNo.Checked = row.Cells["UsoMarcapasos"].Value?.ToString() == "No";
                

                // Obtén el valor de la columna "BiotipoCutaneo" en la fila seleccionada
                object valorr = row.Cells["BiotipoCutaneo"].Value;

                // Asegúrate de que valorr no sea nulo
                if (valorr != null)
                {
                    string biotipoNombre = valorr.ToString();  // Convertir a cadena

                    // Verifica si el nombre existe en el ComboBox (en el campo 'Tipo')
                    var selectedRow = ((DataTable)cmbBiotipoCutaneo.DataSource)
                        .AsEnumerable()
                        .FirstOrDefault(r => r.Field<string>("Tipo") == biotipoNombre);

                    if (selectedRow != null)
                    {
                        // Si se encuentra, asigna el valor del BiotipoCutaneoID al ComboBox
                        cmbBiotipoCutaneo.SelectedValue = selectedRow["BiotipoCutaneoID"];
                    }
                    else
                    {
                        // Si no se encuentra, deselecciona el ComboBox
                        cmbBiotipoCutaneo.SelectedIndex = -1;
                        MessageBox.Show("El valor seleccionado no se encuentra en el ComboBox.");
                    }
                }
                else
                {
                    // Manejo de valor nulo
                    cmbBiotipoCutaneo.SelectedIndex = -1;
                    MessageBox.Show("El valor de la celda es nulo.");
                }


                // Obtener el valor de la columna "Paciente" que contiene el nombre y apellido
                string pacienteCompleto = row.Cells["Paciente"].Value.ToString();

                // Dividir el nombre completo en dos partes (suponiendo que el nombre y apellido están separados por un espacio)
                string[] partesNombre = pacienteCompleto.Split(' ');

                // Asegurarse de que hay al menos dos partes (nombre y apellido)
                if (partesNombre.Length >= 2)
                {
                    string nombre = partesNombre[0];  // Primer parte es el nombre
                    string apellido = partesNombre[1];  // Segunda parte es el apellido

                    // Asignar los valores a los TextBox correspondientes
                    txtNombrePaciente.Text = nombre;
                    txtApellidoPaciente.Text = apellido;

                    
                }


                // Obtener el contenido de la celda de hábitos
                string habitos = row.Cells["Habitos"].Value?.ToString();

                // Dividir la cadena de hábitos por coma para separar cada par clave-valor
                string[] listaHabitos = habitos.Split(',');

                // Iterar sobre cada par clave-valor
                foreach (string habito in listaHabitos)
                {
                    // Limpiar espacios antes y después del texto
                    string habitoTrimmed = habito.Trim();

                    //// Depuración: Verificar cómo se está dividiendo cada hábito
                    //MessageBox.Show("Hábito actual: " + habitoTrimmed);

                    // Dividir cada par clave:valor por el caracter ":"
                    string[] partes = habitoTrimmed.Split(':');

                    if (partes.Length == 2)
                    {
                        string clave = partes[0].Trim();  // La clave
                        string valor = partes[1].Trim();  // El valor

                        //// Depuración: Verificar clave y valor
                        //MessageBox.Show("Clave: " + clave + " | Valor: " + valor);

                        // Asignar los valores a los controles correspondientes según la clave
                        switch (clave)
                        {
                            case "VasosAgua":
                                txtVasosAgua.Text = valor;
                                break;
                            case "ConsumoTabaco":
                                txtConsumoTabaco.Text = valor;
                                break;
                            case "ConsumoMedicamento":
                                txtConsumoMedicamento.Text = valor;
                                break;
                            case "Trasnoche":
                                txtTrasnoche.Text = valor;
                                break;
                            case "ConsumoCafe":
                                txtConsumoCafe.Text = valor;
                                break;
                            case "ConsumoSuplementos":
                                txtConsumoSuplementos.Text = valor;
                                break;
                            case "ConsumoLicor":
                                txtConsumoLicor.Text = valor;
                                break;
                            default:
                                MessageBox.Show("Clave desconocida: " + clave);
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Formato incorrecto en el hábito: " + habitoTrimmed);
                    }
                }
            }


            // Obtener el valor de la columna "Cuidados de Piel"
            string cuidadosPiel = dgvExpediente.Rows[e.RowIndex].Cells["CuidadosPiel"].Value?.ToString();

            // Reinicia los checkboxes
            checkBoxJabonFacial.Checked = false;
            checkBoxTonico.Checked = false;
            checkBoxProtectorSolar.Checked = false;
            checkBoxCremas.Checked = false;
            checkBoxSerum.Checked = false;
            checkBoxAceites.Checked = false;
            checkBoxNinguno.Checked = false;

            // Validar y actualizar los checkboxes
            if (!string.IsNullOrEmpty(cuidadosPiel))
            {
                if (cuidadosPiel.Contains("Jabon Facial")) checkBoxJabonFacial.Checked = true;
                if (cuidadosPiel.Contains("Tonico")) checkBoxTonico.Checked = true;
                if (cuidadosPiel.Contains("Protector Solar")) checkBoxProtectorSolar.Checked = true;
                if (cuidadosPiel.Contains("Cremas")) checkBoxCremas.Checked = true;
                if (cuidadosPiel.Contains("Serum")) checkBoxSerum.Checked = true;
                if (cuidadosPiel.Contains("Aceites")) checkBoxAceites.Checked = true;
                if (cuidadosPiel.Contains("Ninguno")) checkBoxNinguno.Checked = true;
            }

            

        }
    }
}
