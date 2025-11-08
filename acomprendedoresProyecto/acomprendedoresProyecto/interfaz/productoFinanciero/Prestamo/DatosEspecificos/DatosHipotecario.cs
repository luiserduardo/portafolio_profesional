using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acomprendedoresProyecto.pantallas.productoFinanciero.Prestamo.DatosEspecificos.Hipotecario
{
    public partial class DatosHipotecario : UserControl
    {
        public DatosHipotecario()
        {
            InitializeComponent();
        }

        private void txtTipoPropiedad_Leave(object sender, EventArgs e)
        {
            string texto = txtTipoPropiedad.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("El tipo de propiedad no puede estar vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTipoPropiedad.Focus();
                return;
            }

            string patron = @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(texto, patron))
            {
                MessageBox.Show("El tipo de propiedad solo debe contener letras", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTipoPropiedad.Focus();
            }

        }

        private void txtValorPropiedad_Leave(object sender, EventArgs e)
        {
            string texto = txtValorPropiedad.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("El valor de la propiedad no puede estar vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorPropiedad.Focus();
                return;
            }

            if (!double.TryParse(texto, out double valor))
            {
                MessageBox.Show("El valor de la propiedad debe ser un número válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorPropiedad.Focus();
                return;
            }

            if (valor < 0)
            {
                MessageBox.Show("El valor de la propiedad no puede ser negativo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorPropiedad.Focus();
            }

        }

        private void txtDireccionTrabajo_Leave(object sender, EventArgs e)
        {
            string texto = txtDireccionTrabajo.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("La dirección de trabajo no puede estar vacía", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDireccionTrabajo.Focus();
                return;
            }

            string patron = @"^[a-zA-Z0-9áéíóúÁÉÍÓÚñÑ\s]+$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(texto, patron))
            {
                MessageBox.Show("La dirección de trabajo contiene caracteres inválidos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDireccionTrabajo.Focus();
            }

        }
    }
}
