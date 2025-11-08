using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acomprendedoresProyecto.pantallas.productoFinanciero.Prestamo.PantallaDatosGenerales
{
    public partial class DatosGenerales2 : UserControl
    {
        public DatosGenerales2()
        {
            InitializeComponent();
        }

        private void txtPlazo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // bloquea el carácter
            }
        }

        private void txtPlazo_TextChanged(object sender, EventArgs e)
        {
            txtPlazo.Text = new string(txtPlazo.Text.Where(char.IsDigit).ToArray());
            txtPlazo.SelectionStart = txtPlazo.Text.Length; // 

        }

        private void txtCuota_TextChanged(object sender, EventArgs e)
        {
            txtCuota.Text = new string(txtCuota.Text.Where(char.IsDigit).ToArray());
            txtCuota.SelectionStart = txtCuota.Text.Length;

        }
    }
}
