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
    public partial class frmIngresos : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ClinicaBD"].ConnectionString;

        public frmIngresos()
        {
            InitializeComponent();
        }

        private void CargarIngresosDiarios(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("ObtenerIngresosDiarios", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", fechaFin);

                    SqlDataReader reader = cmd.ExecuteReader();

                    // Configurar el DataGridView
                    DataTable table = new DataTable();
                    table.Columns.Add("Fecha", typeof(string));
                    table.Columns.Add("Ingresos Totales", typeof(decimal));

                    while (reader.Read())
                    {
                        DateTime fecha = reader.GetDateTime(0);
                        decimal ingresos = reader.GetDecimal(1);

                        // Añadir filas al DataTable
                        table.Rows.Add(fecha.ToString("yyyy-MM-dd"), ingresos);
                    }

                    reader.Close();

                    // Cargar el DataTable en el DataGridView
                    dgvIngresos.DataSource = table;
                    dgvIngresos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvIngresos.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpInicio.Value;
            DateTime fechaFin = dtpFin.Value;

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("Ingrese fechas correctas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CargarIngresosDiarios(fechaInicio, fechaFin);
        }

        private void CargarMesesDisponibles()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("ObtenerIngresosPorMes", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable meses = new DataTable();
                    da.Fill(meses);

                    // Configurar el ComboBox para mostrar Mes y Año combinados
                    cmbMeses.DisplayMember = "MesAnio"; // Mostrar "2024-01"
                    cmbMeses.ValueMember = "Mes";       // Valor asociado: Mes (entero)
                    cmbMeses.DataSource = meses;

                    // Guardar también el año como columna oculta
                    cmbMeses.Tag = meses; // Guarda el DataTable para uso posterior
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los meses: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarIngresosPorMes(int mes, int anio)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("ObtenerIngresosPorMes", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Mes", mes);
                    cmd.Parameters.AddWithValue("@Anio", anio);

                    SqlDataReader reader = cmd.ExecuteReader();

                    // Leer ingresos totales
                    if (reader.Read())
                    {
                        decimal ingresosTotales = reader.GetDecimal(reader.GetOrdinal("IngresosTotales"));
                        lblIngresosTotales.Text = $"Ingresos Totales: {ingresosTotales.ToString("C", new System.Globalization.CultureInfo("en-US"))}";
                    }

                    // Leer el ranking de procedimientos
                    if (reader.NextResult())
                    {
                        DataTable rankingTable = new DataTable();
                        rankingTable.Load(reader);

                        dgvRanking.DataSource = rankingTable;
                        dgvRanking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los ingresos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbMeses.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)cmbMeses.SelectedItem;
                int mes = Convert.ToInt32(selectedRow["Mes"]);
                int anio = Convert.ToInt32(selectedRow["Anio"]);

                CargarIngresosPorMes(mes, anio);
            }
            else
            {
                MessageBox.Show("Seleccione un mes y un año válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmIngresos_Load(object sender, EventArgs e)
        {
            CargarMesesDisponibles();
        }
    }
}
