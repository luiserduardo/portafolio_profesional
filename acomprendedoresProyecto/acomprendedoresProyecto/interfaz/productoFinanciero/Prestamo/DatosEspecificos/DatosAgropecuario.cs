using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acomprendedoresProyecto.pantallas.productoFinanciero.Prestamo.DatosEspecificos.Agropecurios
{
    public partial class DatosAgropecuario : UserControl
    {
        public DatosAgropecuario()
        {
            InitializeComponent();
        }

        private void txtCuotaSeguro_TextChanged(object sender, EventArgs e)
        {

        }

        private void DatosAgropecuario_Load(object sender, EventArgs e)
        {

        }

        private void txtTipoActividad_Leave(object sender, EventArgs e)
        {
            string texto = txtTipoActividad.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("El tipo de actividad no puede estar vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTipoActividad.Focus();
                return;
            }

            string patron = @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(texto, patron))
            {
                MessageBox.Show("El tipo de actividad solo debe contener letras", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTipoActividad.Focus();
            }
        }

        private void txtCuotaSeguro_Leave(object sender, EventArgs e)
        {

            string texto = txtCuotaSeguro.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("La cuota del seguro no puede estar vacía", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCuotaSeguro.Focus();
                return;
            }

            if (!double.TryParse(texto, out double valor))
            {
                MessageBox.Show("La cuota del seguro debe ser un número válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCuotaSeguro.Focus();
                return;
            }

            if (valor < 0)
            {
                MessageBox.Show("La cuota del seguro no puede ser negativa", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCuotaSeguro.Focus();
            }
        }
    }
}
