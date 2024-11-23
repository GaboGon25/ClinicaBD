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
    public partial class frmOcupaciones : Form
    {
        private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ClinicaBD"].ConnectionString;
        public frmOcupaciones()
        {
            InitializeComponent();
        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

                    dgvOcupaciones.DataSource = dt;
                    dgvOcupaciones.Columns["OcupacionID"].Visible = false;
                    dgvOcupaciones.Columns["Nombre"].HeaderText = "Ocupaciones";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ocupaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmOcupaciones_Load(object sender, EventArgs e)
        {
            CargarOcupaciones();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreOcupacion.Text))
                {
                    MessageBox.Show("El campo vacio es obligatorio. Por favor, complete la información.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Ocupacion (Nombre) VALUES (@Nombre)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Nombre", txtNombreOcupacion.Text.Trim());

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Ocupacion agregada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarOcupaciones();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar la ocupacion. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al agregar una ocupacion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void LimpiarCampos()
        {
            txtNombreOcupacion.Clear();
            txtNombreOcupacion.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtOcupacionID.Text))
                {
                    MessageBox.Show("Seleccione una ocupacion para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("¿Está seguro de que desea guardar los cambios?", "Confirmación",
                                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = @"UPDATE Ocupacion SET Nombre = @Nombre WHERE OcupacionID = @OcupacionID";
                        SqlCommand cmd = new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@Nombre", txtNombreOcupacion.Text.Trim());
                        cmd.Parameters.AddWithValue("@OcupacionID", txtOcupacionID.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ocupacion actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarOcupaciones();
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar la ocupacion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar una ocupacion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvOcupaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOcupaciones.Rows[e.RowIndex];

                txtNombreOcupacion.Text = row.Cells["Nombre"].Value.ToString();
                txtOcupacionID.Text = row.Cells["OcupacionID"].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(txtOcupacionID.Text))
                {
                    MessageBox.Show("Seleccione una ocupación para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta ocupación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "DELETE FROM Ocupacion WHERE OcupacionID = @OcupacionID";
                        SqlCommand cmd = new SqlCommand(query, con);

                        
                        cmd.Parameters.AddWithValue("@OcupacionID", txtOcupacionID.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ocupación eliminada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos(); 
                            CargarOcupaciones(); 
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar la ocupación. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la ocupación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
