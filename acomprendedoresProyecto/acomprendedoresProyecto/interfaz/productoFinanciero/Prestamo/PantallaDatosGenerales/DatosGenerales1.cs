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
    public partial class DatosGenerales1 : UserControl
    {
        public DatosGenerales1()
        {
            InitializeComponent();
        }

        private void DatosGenerales1_Load(object sender, EventArgs e)
        {

        }


        public void CargarDatosGenerales(string codigoPrestmao)
        {
            txtCodigoPrestamo.Text = codigoPrestmao;
        }

        private void validarMonto(object sender, EventArgs e)
        {
            string texto = txtMonto.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("El monto no puede estar vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonto.Focus();
                return;
            }

            if (!double.TryParse(texto, out double valor))
            {
                MessageBox.Show("El monto debe ser un número válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonto.Focus();
                return;
            }

            if (valor < 0)
            {
                MessageBox.Show("El monto no puede ser negativo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonto.Focus();
            }


        }

    }
}
