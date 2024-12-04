using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaBD
{
    public partial class frmHora : Form
    {
        public frmHora()
        {
            InitializeComponent();
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            // Formato de 12 horas con AM/PM
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);

            // Formato de fecha: día de la semana, día del mes y mes
            lblFecha.Text = DateTime.Now.ToString("dddd d 'de' MMMM yyyy", System.Globalization.CultureInfo.CreateSpecificCulture("es-ES"));
        }
    }
}
