using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using acomprendedoresProyecto.clases;
using acomprendedoresProyecto.repositorios;

namespace acomprendedoresProyecto.pantallas.productoFinanciero.Cuenta
{
    public partial class RegistrarCuenta : UserControl
    {


        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        CarteraVirtualRepositorio carteraUsuario = new CarteraVirtualRepositorio();
        Cliente cliente = null;
        CarteraVirtual cartera=null;

        Validacion validacion = new Validacion();


        public RegistrarCuenta()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            
            PanelBeneficiarios panel = new PanelBeneficiarios(1);
            panel1.Controls.Add(panel);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            panel1.Controls.Clear();

            PanelBeneficiarios panel = new PanelBeneficiarios(2);
            panel1.Controls.Add(panel);

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            PanelBeneficiarios panel = new PanelBeneficiarios(3);
            panel1.Controls.Add(panel);

        }


        //buscar
        private void button1_Click(object sender, EventArgs e)
        {
            string codigoBuscar = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(codigoBuscar))
            {
                MessageBox.Show("Ingrese un código para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar cliente
            cliente = usuarioRepositorio.ObtenerClientePorCodigoDUI(codigoBuscar);

            if (cliente == null)
            {
                MessageBox.Show("No se encontró ningún cliente con ese código.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCodigoCartera.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtDUI.Clear();
                txtCodigoUsuario.Clear();
                txtCorreo.Clear();
                txtUsuario.Clear();

                cartera = null;
                return;
            }

            cartera = carteraUsuario.ObtenerCarteraPorCliente(cliente.CodigoUsuario);

            if (cartera == null)
            {
                MessageBox.Show("El cliente no tiene una cartera asociada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigoCartera.Clear();
                return;
            }

            txtCodigoCartera.Text = cartera.CodigoCartera;
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtCodigoUsuario.Text = cliente.CodigoUsuario;
            txtCorreo.Text = cliente.CorreoElectronico;
            txtDUI.Text = cliente.DUI;
            txtUsuario.Text = cliente.CodigoUsuario;




        }

        private void generacionNumeroCUenta(object sender, EventArgs e)
        {

            int anioActual = DateTime.Now.Year;

            Random random = new Random();
            int numero = random.Next(1, 100000);

            string numeroFormateado = numero.ToString("D3");

            string numeroCuenta = $"CTA-{numeroFormateado}-{anioActual}";

            txtNumeroCuenta.Text = numeroCuenta;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string numeroProducto = txtNumeroCuenta.Text.Trim();
            if (string.IsNullOrEmpty(numeroProducto))
            {
                MessageBox.Show("Debe generar un número de cuenta primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cartera == null)
            {
                MessageBox.Show("No se ha seleccionado una cartera válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string codigoCartera = cartera.CodigoCartera;

            string tipoCuenta = txtTipoCuenta.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(tipoCuenta))
            {
                MessageBox.Show("Seleccione un tipo de cuenta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (double.Parse(txtSaldo.Text) < 0)
            {
                MessageBox.Show("Ingrese un saldo inicial válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (panel1.Controls.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un beneficiario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PanelBeneficiarios panelBenef = panel1.Controls[0] as PanelBeneficiarios;
            if (panelBenef == null || panelBenef.Beneficiarios.Count == 0)
            {
                MessageBox.Show("Debe registrar los beneficiarios correctamente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<Beneficiarios> beneficiarios = panelBenef.Beneficiarios;

            ProductosRepositorio repo = new ProductosRepositorio();
            bool resultado = repo.CrearProductoFinancieroCuenta(numeroProducto, codigoCartera, tipoCuenta, double.Parse(txtSaldo.Text), beneficiarios);

            if (resultado)
            {
                MessageBox.Show("Producto financiero creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNumeroCuenta.Clear();
                txtTipoCuenta.SelectedIndex = -1;
                txtSaldo.Clear();
                panel1.Controls.Clear();
            }
            else
            {
                MessageBox.Show("Error al crear el producto financiero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtSaldo_Leave(object sender, EventArgs e)
        {
            validacion.ValidarSalario(txtSaldo.Text);

        }
    }
}
