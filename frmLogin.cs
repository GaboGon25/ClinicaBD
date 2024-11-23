using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaBD
{
    public partial class frmLogin : Form
    {
        private readonly AdminLogin adminLogin;
        frmCentral frm = new frmCentral();
        public frmLogin()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["ClinicaBD"].ConnectionString;
            adminLogin = new AdminLogin(connectionString);
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text != "USUARIO")
                {
                    if (txtPassword.Text != "CONTRASEÑA")
                    {
                        var validLogin = adminLogin.Login(txtUsername.Text, txtPassword.Text);
                        if (validLogin == true)
                        {
                            //frm.ShowDialog();

                            if (this.InvokeRequired)
                            {
                                this.Invoke(new Action(() =>
                                {
                                    frm.Show();
                                }));
                            }
                            else
                            {
                                frm.Show();
                            }

                            // Oculta el formulario de login
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("El Usuario y Contraseña no existe");
                            txtPassword.Clear();
                            txtUsername.Clear();
                            txtPassword.UseSystemPasswordChar = true;
                            txtUsername.Focus();
                        }


                    }
                    else
                    {
                        MessageBox.Show("Ingrese una contraseña válida.");
                        txtPassword.Focus();
                        txtPassword.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un usuario válido.");
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
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
    }
}
