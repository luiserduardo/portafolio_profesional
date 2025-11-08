using System;
using System.Collections.Generic;
using System.Windows.Forms;
using acomprendedoresProyecto.clases;

namespace acomprendedoresProyecto.pantallas.productoFinanciero.Cuenta
{
    public partial class PanelBeneficiarios : UserControl
    {
        private int cantidadTotal;
        private int contador = 0;
        private List<Beneficiarios> beneficiarios = new List<Beneficiarios>();

        public List<Beneficiarios> Beneficiarios => beneficiarios;

        public PanelBeneficiarios(int cantidad)
        {
            InitializeComponent();
            cantidadTotal = cantidad;

            btnSiguiente.Visible = false;

            ActualizarNumeroBeneficiario();

            txtNombreBeneficiario.TextChanged += MostrarBotonSiCamposLlenos;
            txtApellidosBeneficiarios.TextChanged += MostrarBotonSiCamposLlenos;
            txtDui.TextChanged += MostrarBotonSiCamposLlenos;
            textBox1.TextChanged += MostrarBotonSiCamposLlenos;
        }

        private void ActualizarNumeroBeneficiario()
        {
            txtNumeroBeneficiario.Text = $"{contador + 1} de {cantidadTotal}";
        }

        private void LimpiarCampos()
        {
            txtNombreBeneficiario.Clear();
            txtApellidosBeneficiarios.Clear();
            txtDui.Clear();
            textBox1.Clear();
            btnSiguiente.Visible = false; 
        }

        private void MostrarBotonSiCamposLlenos(object sender, EventArgs e)
        {
            btnSiguiente.Visible =
                !string.IsNullOrWhiteSpace(txtNombreBeneficiario.Text) &&
                !string.IsNullOrWhiteSpace(txtApellidosBeneficiarios.Text) &&
                !string.IsNullOrWhiteSpace(txtDui.Text) &&
                !string.IsNullOrWhiteSpace(textBox1.Text);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreBeneficiario.Text.Trim();
            string apellido = txtApellidosBeneficiarios.Text.Trim();
            string dui = txtDui.Text.Trim();
            string parentesco = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(dui) || string.IsNullOrEmpty(parentesco))
            {
                MessageBox.Show("Complete todos los campos antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Beneficiarios b = new Beneficiarios
            {
                Nombre = nombre,
                Apellido = apellido,
                DUI = dui,
                Parentesco = parentesco
            };

            beneficiarios.Add(b);
            contador++;

            if (contador >= cantidadTotal)
            {
                btnSiguiente.Enabled = false;
                LimpiarCampos();
                txtNumeroBeneficiario.Text = $"{cantidadTotal} de {cantidadTotal}";
                MessageBox.Show("Todos los beneficiarios han sido registrados.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LimpiarCampos();
                ActualizarNumeroBeneficiario();
                MessageBox.Show($"Beneficiario {contador} agregado. Faltan {cantidadTotal - contador}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
