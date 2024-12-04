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
    public partial class frmCitas : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ClinicaBD"].ConnectionString;
        private int pacienteIDSeleccionado;
        public frmCitas()
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

            Console.WriteLine($"SetPacienteSeleccionado ejecutado con Nombre: {nombre}, Apellido: {apellido}");
            txtNombrePaciente.Text = nombre;
            txtApellidoPaciente.Text = apellido;
            this.pacienteIDSeleccionado = pacienteID;

            // Deshabilitar los campos para evitar ediciones
            txtNombrePaciente.ReadOnly = true;
            txtApellidoPaciente.ReadOnly = true;
        }

        private void CargarProcedimientos()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString)) // Reemplaza con tu cadena de conexión
                {
                    con.Open();
                    string query = "SELECT ProcedimientoID, Titulo FROM Procedimientos";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbProcedimientos.DisplayMember = "Titulo"; // El nombre que se mostrará en el ComboBox
                    cmbProcedimientos.ValueMember = "ProcedimientoID"; // El valor asociado a cada ítem
                    cmbProcedimientos.DataSource = dt; // Asignar la fuente de datos

                    //Campo Adicional

                    // Crear una copia del DataTable para el segundo ComboBox
                    DataTable dtCopy = dt.Copy();
                    cmbProcedimientos2.DisplayMember = "Titulo";
                    cmbProcedimientos2.ValueMember = "ProcedimientoID";
                    cmbProcedimientos2.DataSource = dtCopy;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar procedimientos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEstado()
        {
            cmbEstado.Items.Clear();  // Limpiar los elementos previos
            // Crear los valores para el ComboBox
            cmbEstado.Items.Add(new KeyValuePair<int, string>(1, "Activo"));
            cmbEstado.Items.Add(new KeyValuePair<int, string>(0, "Inactivo"));

            // Configurar qué mostrar y qué usar como valor
            cmbEstado.DisplayMember = "Value"; // Texto visible
            cmbEstado.ValueMember = "Key";    // Valor subyacente

            // Seleccionar un valor por defecto (opcional)
            cmbEstado.SelectedIndex = 0;
        }

        private void frmCitas_Load(object sender, EventArgs e)
        {
            CargarProcedimientos();
            CargarEstado();
            CargarCitasEnGrid();

            cmbProcedimientos2.Enabled = false;
            txtValor2.Enabled = false;
        }



        private void cmbProcedimientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbProcedimientos.SelectedValue != null)
                {
                    using (SqlConnection con = new SqlConnection(connectionString)) // Reemplaza con tu cadena de conexión
                    {
                        con.Open();
                        string query = "SELECT Costo FROM Procedimientos WHERE ProcedimientoID = @ProcedimientoID";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@ProcedimientoID", cmbProcedimientos.SelectedValue); // Usa el valor seleccionado

                            object result = cmd.ExecuteScalar(); // Ejecuta la consulta y obtiene un único valor
                            if (result != null)
                            {
                                txtValor.Text = result.ToString(); // Muestra el costo en el TextBox
                            }
                            else
                            {
                                txtValor.Text = string.Empty; // Limpia el TextBox si no hay resultado
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el costo del procedimiento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxProcedimientoAdicional_CheckedChanged(object sender, EventArgs e)
        {
            // Habilitar o deshabilitar los controles según el estado del CheckBox
            bool habilitar = cbxProcedimientoAdicional.Checked;

            cmbProcedimientos2.Enabled = habilitar; // Habilita o deshabilita el ComboBox adicional
            txtValor2.Enabled = habilitar;        // Habilita o deshabilita el TextBox adiciona
        }

        private void cmbProcedimientos2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbProcedimientos2.SelectedValue != null)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "SELECT Costo FROM Procedimientos WHERE ProcedimientoID = @ProcedimientoID";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@ProcedimientoID", cmbProcedimientos2.SelectedValue);

                            object result = cmd.ExecuteScalar();
                            if (result != null)
                            {
                                txtValor2.Text = result.ToString();
                            }
                            else
                            {
                                txtValor2.Text = string.Empty;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el costo del procedimiento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertarProcedimiento(int citaID, object procedimientoID, string costo)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string insertProcedimientoQuery = "INSERT INTO Citas_Procedimientos (CitaID, ProcedimientoID, Costo_Procedimiento) " +
                                                  "VALUES (@CitaID, @ProcedimientoID, @Costo)";
                SqlCommand cmd = new SqlCommand(insertProcedimientoQuery, con);
                cmd.Parameters.AddWithValue("@CitaID", citaID);
                cmd.Parameters.AddWithValue("@ProcedimientoID", procedimientoID);
                cmd.Parameters.AddWithValue("@Costo", decimal.Parse(costo));

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void CargarCitasEnGrid()
        {
            //            try
            //            {
            //                using (SqlConnection con = new SqlConnection(connectionString))
            //                {
            //                    string query = @"
            //SELECT 
            //    c.CitaID,
            //    p.Nombre + ' ' + p.Apellido AS Paciente,
            //    c.Fecha,
            //    c.Hora,
            //    c.Motivo_Cita,
            //    c.Estado,
            //    STRING_AGG(pr.Titulo, ', ') AS Procedimientos,
            //    STRING_AGG(CAST(cp.Costo_Procedimiento AS VARCHAR), ', ') AS Costos
            //FROM Citas c
            //INNER JOIN Paciente p ON c.PacienteID = p.PacienteID
            //LEFT JOIN Citas_Procedimientos cp ON c.CitaID = cp.CitaID
            //LEFT JOIN Procedimientos pr ON cp.ProcedimientoID = pr.ProcedimientoID
            //GROUP BY 
            //    c.CitaID, p.Nombre, p.Apellido, c.Fecha, c.Hora, c.Motivo_Cita, c.Estado";

            //                    SqlDataAdapter da = new SqlDataAdapter(query, con);
            //                    DataTable dt = new DataTable();
            //                    da.Fill(dt);

            //                    dgvCitas.DataSource = dt; // Mostrar los datos en el DataGridView

            //                    // Aseguramos que la columna "Estado" tenga valores booleanos (true/false)
            //                    foreach (DataGridViewRow row in dgvCitas.Rows)
            //                    {
            //                        // Verificamos si la celda "Estado" no es nula y tiene un valor válido
            //                        if (row.Cells["Estado"].Value != DBNull.Value && row.Cells["Estado"].Value != null)
            //                        {
            //                            // Intentamos convertir el valor a booleano de forma segura
            //                            bool estado = false;
            //                            if (bool.TryParse(row.Cells["Estado"].Value.ToString(), out estado))
            //                            {
            //                                row.Cells["Estado"].Value = estado; // Marcamos el checkbox
            //                            }
            //                            else
            //                            {
            //                                row.Cells["Estado"].Value = false; // Si no es un valor booleano, lo dejamos como falso
            //                            }
            //                        }
            //                        else
            //                        {
            //                            // Si el valor es nulo o DBNull, lo asignamos como falso
            //                            row.Cells["Estado"].Value = false;
            //                        }
            //                    }
            //                }
            //            }
            //            catch (Exception ex)
            //            {
            //                MessageBox.Show("Error al cargar citas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
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
                END AS Estado,
                STRING_AGG(pr.Titulo, ', ') AS Procedimientos,
                STRING_AGG(CAST(cp.Costo_Procedimiento AS VARCHAR), ', ') AS Costos
            FROM Citas c
            INNER JOIN Paciente p ON c.PacienteID = p.PacienteID
            LEFT JOIN Citas_Procedimientos cp ON c.CitaID = cp.CitaID
            LEFT JOIN Procedimientos pr ON cp.ProcedimientoID = pr.ProcedimientoID
            GROUP BY 
                c.CitaID, p.Nombre, p.Apellido, c.Fecha, c.Hora, c.Motivo_Cita, c.Estado";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvCitas.DataSource = dt; // Mostrar los datos en el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar citas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    using (SqlConnection con = new SqlConnection(connectionString))
            //    {
            //        con.Open();

            //        // Verificar que haya un paciente seleccionado antes de proceder
            //        if (pacienteIDSeleccionado <= 0)
            //        {
            //            MessageBox.Show("Por favor, seleccione un paciente antes de registrar la cita.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            return;
            //        }

            //        // 1. Insertar la cita en la tabla Citas y obtener el CitaID
            //        string insertCitaQuery = "INSERT INTO Citas (PacienteID, Fecha, Hora, Motivo_Cita, Estado) " +
            //                                  "OUTPUT INSERTED.CitaID VALUES (@PacienteID, @Fecha, @Hora, @Motivo, @Estado)";
            //        SqlCommand cmdCita = new SqlCommand(insertCitaQuery, con);
            //        cmdCita.Parameters.AddWithValue("@PacienteID", pacienteIDSeleccionado);
            //        cmdCita.Parameters.AddWithValue("@Fecha", dtpFecha.Value.Date);
            //        cmdCita.Parameters.AddWithValue("@Hora", dtpHora.Value.TimeOfDay);
            //        cmdCita.Parameters.AddWithValue("@Motivo", txtMotivo.Text);
            //        cmdCita.Parameters.AddWithValue("@Estado", cbxProcedimientoAdicional.Checked ? 1 : 0);

            //        int citaID = (int)cmdCita.ExecuteScalar(); // Obtener el ID de la cita creada   

            //        // 2. Insertar procedimientos seleccionados en Citas_Procedimientos
            //        if (cmbProcedimientos.SelectedValue != null)
            //        {
            //            InsertarProcedimiento(citaID, cmbProcedimientos.SelectedValue, txtValor.Text);
            //        }

            //        if (cbxProcedimientoAdicional.Checked && cmbProcedimientos2.SelectedValue != null)
            //        {
            //            InsertarProcedimiento(citaID, cmbProcedimientos2.SelectedValue, txtValor2.Text);
            //        }

            //        // 3. Actualizar el DataGridView para mostrar los datos actualizados
            //        CargarCitasEnGrid();
            //        MessageBox.Show("Cita registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al registrar la cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Verificar que haya un paciente seleccionado antes de proceder
                    if (pacienteIDSeleccionado <= 0)
                    {
                        MessageBox.Show("Por favor, seleccione un paciente antes de registrar la cita.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Verificar que se haya seleccionado un estado (Activo/Inactivo) en el ComboBox
                    if (cmbEstado.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione el estado de la cita.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Obtener el valor de Estado desde el ComboBox
                    int estado = ((KeyValuePair<int, string>)cmbEstado.SelectedItem).Key;

                    // 1. Insertar la cita en la tabla Citas y obtener el CitaID
                    string insertCitaQuery = "INSERT INTO Citas (PacienteID, Fecha, Hora, Motivo_Cita, Estado) " +
                                              "OUTPUT INSERTED.CitaID VALUES (@PacienteID, @Fecha, @Hora, @Motivo, @Estado)";
                    SqlCommand cmdCita = new SqlCommand(insertCitaQuery, con);
                    cmdCita.Parameters.AddWithValue("@PacienteID", pacienteIDSeleccionado);
                    cmdCita.Parameters.AddWithValue("@Fecha", dtpFecha.Value.Date);
                    cmdCita.Parameters.AddWithValue("@Hora", dtpHora.Value.TimeOfDay);
                    cmdCita.Parameters.AddWithValue("@Motivo", txtMotivo.Text);
                    cmdCita.Parameters.AddWithValue("@Estado", estado);  // Usar el estado seleccionado

                    int citaID = (int)cmdCita.ExecuteScalar(); // Obtener el ID de la cita creada

                    // 2. Insertar procedimientos seleccionados en Citas_Procedimientos
                    if (cmbProcedimientos.SelectedValue != null)
                    {
                        InsertarProcedimiento(citaID, cmbProcedimientos.SelectedValue, txtValor.Text);
                    }

                    if (cbxProcedimientoAdicional.Checked && cmbProcedimientos2.SelectedValue != null)
                    {
                        InsertarProcedimiento(citaID, cmbProcedimientos2.SelectedValue, txtValor2.Text);
                    }

                    // 3. Actualizar el DataGridView para mostrar los datos actualizados
                    CargarCitasEnGrid();
                    MessageBox.Show("Cita registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal string GetValorForProcedimiento(string procedimiento)
        {

            procedimiento = procedimiento.Trim(); // Limpiamos espacios
            var procedimientosValores = new Dictionary<string, string>
    {
        { "Dermapen", "40" },
        { "LaserHollyWoodPeel", "35" },
        { "Exeresis de verrugas", "10" },
        { "Plasma Gel", "30" },
        { "Hydrafacial", "35" },
        { "Relleno con acido hialuronico", "120" },
        { "Limpieza facial profunda", "30" },
        { "Peeling Facial", "40" },
        { "Bioestimulacion facial con plasma", "40" },
        { "Blefaropastia no quirurgica de parpados", "30" },
        { "Botox", "140" }
    };

            if (procedimientosValores.ContainsKey(procedimiento))
            {
                return procedimientosValores[procedimiento];
            }
            else
            {
                return "0,00";  // O puedes devolver otro valor por defecto si lo prefieres
            }
        }

        private void dgvCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    // Asegurarse de que se haya hecho clic en una fila válida
            //    if (e.RowIndex >= 0)
            //    {
            //        // Obtener la fila seleccionada
            //        DataGridViewRow row = dgvCitas.Rows[e.RowIndex];

            //        // Obtener el valor de la columna "Paciente" que contiene el nombre y apellido
            //        string pacienteCompleto = row.Cells["Paciente"].Value.ToString();

            //        // Dividir el nombre completo en dos partes (suponiendo que el nombre y apellido están separados por un espacio)
            //        string[] partesNombre = pacienteCompleto.Split(' ');

            //        // Asegurarse de que hay al menos dos partes (nombre y apellido)
            //        if (partesNombre.Length >= 2)
            //        {
            //            string nombre = partesNombre[0];  // Primer parte es el nombre
            //            string apellido = partesNombre[1];  // Segunda parte es el apellido

            //            // Asignar los valores a los TextBox correspondientes
            //            txtNombrePaciente.Text = nombre;
            //            txtApellidoPaciente.Text = apellido;

            //            // También puedes almacenar el ID del paciente para utilizarlo más tarde
            //            pacienteIDSeleccionado = (int)row.Cells["CitaID"].Value;  // Aquí puedes almacenar el ID de la cita si lo necesitas
            //        }

            //       //Obteniendo Procedimientps

            //        if (row.Cells["Procedimientos"].Value == DBNull.Value || row.Cells["Procedimientos"].Value == null || string.IsNullOrWhiteSpace(row.Cells["Procedimientos"].Value.ToString()))
            //        {
            //            // Si no hay procedimiento, limpiar los campos
            //            cmbProcedimientos.Text = "";
            //            txtValor.Text = "";
            //            cbxProcedimientoAdicional.Checked = false;
            //            cmbProcedimientos2.Text = "";
            //            cmbProcedimientos2.Enabled = false;
            //            txtValor2.Text = "";
            //            txtValor2.Enabled = false;
            //        }
            //        else
            //        {
            //            string procedimientos = row.Cells["Procedimientos"].Value.ToString();
            //            string[] procedimientosArray = procedimientos.Split(',');

            //            // Procedimiento principal
            //            cmbProcedimientos.Text = procedimientosArray.Length > 0 ? procedimientosArray[0].Trim() : "";

            //            // Procedimiento adicional
            //            if (procedimientosArray.Length > 1)
            //            {
            //                cbxProcedimientoAdicional.Checked = true;
            //                cmbProcedimientos2.Enabled = true;
            //                txtValor2.Enabled = true;
            //                cmbProcedimientos2.Text = procedimientosArray[1].Trim();
            //                txtValor2.Text = GetValorForProcedimiento(procedimientosArray[1]);
            //            }
            //            else
            //            {
            //                cbxProcedimientoAdicional.Checked = false;
            //                cmbProcedimientos2.Enabled = false;
            //                txtValor2.Enabled = false;
            //                cmbProcedimientos2.Text = "";
            //                txtValor2.Text = "";
            //            }

            //            // Valor del primer procedimiento
            //            txtValor.Text = procedimientosArray.Length > 0 ? GetValorForProcedimiento(procedimientosArray[0]) : "";
            //        }



            //        // Obtener el valor de la columna "Costo" que contiene uno o dos costos
            //        string costo = row.Cells["Costos"].Value.ToString();
            //        string[] costosArray = costo.Split(',');

            //        // Asignar el costo al TextBox (considerando que puede haber uno o dos costos)
            //        if (costosArray.Length >= 1)
            //        {
            //            txtValor.Text = costosArray[0].Trim();  // Asignar el primer costo
            //        }
            //        if (costosArray.Length >= 2)
            //        {
            //            // Si existe un segundo costo, puedes manejarlo de la forma que necesites
            //            // De manera similar a los procedimientos, puedes asignarlo a otro TextBox o manejarlo según lo que necesites.
            //        }

            //        // Obtener y asignar la fecha (dtpFecha) y hora (dtpHora)
            //        // La columna de "Fecha" contiene la fecha completa (día, mes, año)
            //        if (row.Cells["Fecha"].Value != DBNull.Value)
            //        {
            //            DateTime fecha = Convert.ToDateTime(row.Cells["Fecha"].Value);
            //            dtpFecha.Value = fecha;  // Asignar la fecha al DateTimePicker
            //        }

            //        if (row.Cells["Hora"].Value != DBNull.Value)
            //        {
            //            string horaString = row.Cells["Hora"].Value.ToString();
            //            TimeSpan hora;
            //            if (TimeSpan.TryParse(horaString, out hora))
            //            {
            //                DateTime horaDateTime = DateTime.Today.Add(hora);  // Asignar la hora al DateTimePicker
            //                dtpHora.Value = horaDateTime;
            //            }
            //            else
            //            {
            //                // Si no se puede convertir, podrías manejar el error aquí
            //                MessageBox.Show("Formato de hora inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }

            //        // Asignar el motivo al TextBox (txtMotivo)
            //        if (row.Cells["Motivo_Cita"].Value != DBNull.Value)
            //        {
            //            txtMotivo.Text = row.Cells["Motivo_Cita"].Value.ToString();
            //        }


            //        // Obtiene el valor de la celda "Estado" (booleano)
            //        bool estado = (bool)row.Cells["Estado"].Value;

            //        // Aquí se hace la asignación correcta del estado al ComboBox
            //        if (estado)
            //        {
            //            cmbEstado.SelectedItem = cmbEstado.Items.Cast<KeyValuePair<int, string>>()
            //                .FirstOrDefault(x => x.Value == "Activo");
            //        }
            //        else
            //        {
            //            cmbEstado.SelectedItem = cmbEstado.Items.Cast<KeyValuePair<int, string>>()
            //                .FirstOrDefault(x => x.Value == "Inactivo");
            //        }

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al manejar el clic en la celda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}



            try
            {
                // Asegurarse de que se haya hecho clic en una fila válida
                if (e.RowIndex >= 0)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow row = dgvCitas.Rows[e.RowIndex];

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

                        // También puedes almacenar el ID del paciente para utilizarlo más tarde
                        pacienteIDSeleccionado = (int)row.Cells["CitaID"].Value;  // Aquí puedes almacenar el ID de la cita si lo necesitas
                    }

                    // Obteniendo Procedimientos
                    if (row.Cells["Procedimientos"].Value == DBNull.Value || row.Cells["Procedimientos"].Value == null || string.IsNullOrWhiteSpace(row.Cells["Procedimientos"].Value.ToString()))
                    {
                        // Si no hay procedimiento, limpiar los campos
                        cmbProcedimientos.Text = "";
                        txtValor.Text = "";
                        cbxProcedimientoAdicional.Checked = false;
                        cmbProcedimientos2.Text = "";
                        cmbProcedimientos2.Enabled = false;
                        txtValor2.Text = "";
                        txtValor2.Enabled = false;
                    }
                    else
                    {
                        string procedimientos = row.Cells["Procedimientos"].Value.ToString();
                        string[] procedimientosArray = procedimientos.Split(',');

                        // Procedimiento principal
                        cmbProcedimientos.Text = procedimientosArray.Length > 0 ? procedimientosArray[0].Trim() : "";

                        // Procedimiento adicional
                        if (procedimientosArray.Length > 1)
                        {
                            cbxProcedimientoAdicional.Checked = true;
                            cmbProcedimientos2.Enabled = true;
                            txtValor2.Enabled = true;
                            cmbProcedimientos2.Text = procedimientosArray[1].Trim();
                            txtValor2.Text = GetValorForProcedimiento(procedimientosArray[1]);
                        }
                        else
                        {
                            cbxProcedimientoAdicional.Checked = false;
                            cmbProcedimientos2.Enabled = false;
                            txtValor2.Enabled = false;
                            cmbProcedimientos2.Text = "";
                            txtValor2.Text = "";
                        }

                        // Valor del primer procedimiento
                        txtValor.Text = procedimientosArray.Length > 0 ? GetValorForProcedimiento(procedimientosArray[0]) : "";
                    }

                    // Obtener el valor de la columna "Costo" que contiene uno o dos costos
                    string costo = row.Cells["Costos"].Value.ToString();
                    string[] costosArray = costo.Split(',');

                    // Asignar el costo al TextBox (considerando que puede haber uno o dos costos)
                    if (costosArray.Length >= 1)
                    {
                        txtValor.Text = costosArray[0].Trim();  // Asignar el primer costo
                    }
                    if (costosArray.Length >= 2)
                    {
                        // Si existe un segundo costo, puedes manejarlo de la forma que necesites
                        // De manera similar a los procedimientos, puedes asignarlo a otro TextBox o manejarlo según lo que necesites.
                    }

                    // Obtener y asignar la fecha (dtpFecha) y hora (dtpHora)
                    // La columna de "Fecha" contiene la fecha completa (día, mes, año)
                    if (row.Cells["Fecha"].Value != DBNull.Value)
                    {
                        DateTime fecha = Convert.ToDateTime(row.Cells["Fecha"].Value);
                        dtpFecha.Value = fecha;  // Asignar la fecha al DateTimePicker
                    }

                    if (row.Cells["Hora"].Value != DBNull.Value)
                    {
                        string horaString = row.Cells["Hora"].Value.ToString();
                        TimeSpan hora;
                        if (TimeSpan.TryParse(horaString, out hora))
                        {
                            DateTime horaDateTime = DateTime.Today.Add(hora);  // Asignar la hora al DateTimePicker
                            dtpHora.Value = horaDateTime;
                        }
                        else
                        {
                            // Si no se puede convertir, podrías manejar el error aquí
                            MessageBox.Show("Formato de hora inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    // Asignar el motivo al TextBox (txtMotivo)
                    if (row.Cells["Motivo_Cita"].Value != DBNull.Value)
                    {
                        txtMotivo.Text = row.Cells["Motivo_Cita"].Value.ToString();
                    }

                    // Obtiene el valor de la celda "Estado" (string)
                    string estadoString = row.Cells["Estado"].Value.ToString();

                    // Determinar si el estado es "Activo" o "Inactivo"
                    bool estado = estadoString.Equals("Activo", StringComparison.OrdinalIgnoreCase);

                    // Aquí se hace la asignación correcta del estado al ComboBox
                    if (estado)
                    {
                        cmbEstado.SelectedItem = cmbEstado.Items.Cast<KeyValuePair<int, string>>()
                            .FirstOrDefault(x => x.Value == "Activo");
                    }
                    else
                    {
                        cmbEstado.SelectedItem = cmbEstado.Items.Cast<KeyValuePair<int, string>>()
                            .FirstOrDefault(x => x.Value == "Inactivo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al manejar el clic en la celda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


  

        private void btnEditar_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    // Asegurarse de que el paciente o cita haya sido seleccionada
            //    if (pacienteIDSeleccionado <= 0)
            //    {
            //        MessageBox.Show("Por favor, seleccione una cita para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    using (SqlConnection con = new SqlConnection(connectionString))
            //    {
            //        con.Open();

            //        // Actualizar la cita
            //        string updateCitaQuery = "UPDATE Citas SET PacienteID = @PacienteID, Fecha = @Fecha, Hora = @Hora, Motivo_Cita = @Motivo, Estado = @Estado WHERE CitaID = @CitaID";
            //        SqlCommand cmd = new SqlCommand(updateCitaQuery, con);
            //        cmd.Parameters.AddWithValue("@CitaID", pacienteIDSeleccionado); // Usar el CitaID que se seleccionó
            //        cmd.Parameters.AddWithValue("@PacienteID", pacienteIDSeleccionado); // Asignar el PacienteID de la cita
            //        cmd.Parameters.AddWithValue("@Fecha", dtpFecha.Value.Date);
            //        cmd.Parameters.AddWithValue("@Hora", dtpHora.Value.TimeOfDay);
            //        cmd.Parameters.AddWithValue("@Motivo", txtMotivo.Text);
            //        cmd.Parameters.AddWithValue("@Estado", cmbEstado.SelectedItem.ToString() == "Activo" ? 1 : 0);

            //        // Ejecutar la actualización de la cita
            //        cmd.ExecuteNonQuery();

            //        // Actualizar procedimientos si se han cambiado
            //        string deleteProcedimientosQuery = "DELETE FROM Citas_Procedimientos WHERE CitaID = @CitaID";
            //        SqlCommand cmdDeleteProcedimientos = new SqlCommand(deleteProcedimientosQuery, con);
            //        cmdDeleteProcedimientos.Parameters.AddWithValue("@CitaID", pacienteIDSeleccionado);
            //        cmdDeleteProcedimientos.ExecuteNonQuery();

            //        // Insertar nuevos procedimientos (si se ha seleccionado alguno)
            //        if (cmbProcedimientos.SelectedValue != null)
            //        {
            //            InsertarProcedimiento(pacienteIDSeleccionado, cmbProcedimientos.SelectedValue, txtValor.Text);
            //        }

            //        if (cbxProcedimientoAdicional.Checked && cmbProcedimientos2.SelectedValue != null)
            //        {
            //            InsertarProcedimiento(pacienteIDSeleccionado, cmbProcedimientos2.SelectedValue, txtValor2.Text);
            //        }

            //        // Refrescar el DataGridView con los datos actualizados
            //        CargarCitasEnGrid();

            //        MessageBox.Show("Cita editada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al editar la cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            try
            {
                // Validar que se haya seleccionado una cita
                if (pacienteIDSeleccionado <= 0)
                {
                    MessageBox.Show("Por favor, seleccione una cita para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que se haya ingresado un motivo para la cita
                if (string.IsNullOrWhiteSpace(txtMotivo.Text))
                {
                    MessageBox.Show("Por favor, ingrese un motivo para la cita.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Obtener el estado seleccionado desde el ComboBox
                    if (cmbEstado.SelectedItem == null)
                    {
                        MessageBox.Show("Por favor, seleccione un estado válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Asegurarse de que el estado seleccionado sea válido
                    int estado = ((KeyValuePair<int, string>)cmbEstado.SelectedItem).Key;

                    if (estado != 1 && estado != 0) // Asegurarse de que solo se acepten estados válidos
                    {
                        MessageBox.Show("El estado seleccionado no es válido. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Actualizar la cita
                    string updateCitaQuery = @"
            UPDATE Citas 
            SET Estado = @Estado, 
                PacienteID = @PacienteID, 
                Fecha = @Fecha, 
                Hora = @Hora, 
                Motivo_Cita = @Motivo 
            WHERE CitaID = @CitaID";

                    using (SqlCommand cmd = new SqlCommand(updateCitaQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@CitaID", pacienteIDSeleccionado);
                        cmd.Parameters.AddWithValue("@Estado", estado);
                        cmd.Parameters.AddWithValue("@PacienteID", pacienteIDSeleccionado);
                        cmd.Parameters.AddWithValue("@Fecha", dtpFecha.Value.Date);
                        cmd.Parameters.AddWithValue("@Hora", dtpHora.Value.TimeOfDay);
                        cmd.Parameters.AddWithValue("@Motivo", txtMotivo.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("No se pudo actualizar el estado de la cita. Verifique los datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Refrescar el DataGridView con los datos actualizados
                    CargarCitasEnGrid();

                    MessageBox.Show("Cita editada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error de base de datos al editar la cita: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al editar la cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }


}
