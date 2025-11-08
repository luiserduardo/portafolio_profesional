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

namespace acomprendedoresProyecto.ui.transaccion
{
    public partial class deposito : UserControl
    {

        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        Cliente cliente;
        CarteraVirtual cartera;
        CarteraVirtualRepositorio carteraUsuario = new CarteraVirtualRepositorio();
        ProductosRepositorio productoRepo = new ProductosRepositorio();
        TransaccionesRepositorio TransaccionesRepositorio = new TransaccionesRepositorio();
        string empleado;


        //Guarda temporarlament cuenta actual
        private List<Cuenta> cuentasCliente = new List<Cuenta>();

        public deposito(string empleado)
        {
            InitializeComponent();
            this.empleado = empleado;

            txtCodigoEmpleado.Text = empleado;
        }

        private void deposito_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigoBuscar = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(codigoBuscar))
            {
                MessageBox.Show("Ingrese un código para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            cliente = usuarioRepositorio.ObtenerClientePorCodigoDUI(codigoBuscar);

            if (cliente == null)
            {
                MessageBox.Show("No se encontró ningún cliente con ese código.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCodigoCartera.Clear();

                cartera = null;
                return;
            }

            cartera = carteraUsuario.ObtenerCarteraPorCliente(cliente.CodigoUsuario);


            if (cartera == null)
            {
                MessageBox.Show("El cliente no tiene una cartera asociada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpiar campos visibles
                txtCodigoCartera.Clear();
                return;
            }

            txtCodigoCartera.Text = cartera.CodigoCartera;
            txtcodigoCliente.Text = cliente.CodigoUsuario;

            CargarCuenstasDestiono(cartera.CodigoCartera);



        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }


        private void CargarCuenstasDestiono(string codigoCartera)
        {
            try
            {
                cmbNumeroCuenta.Items.Clear();

                cuentasCliente = productoRepo.RecuperarCuentaDestinoDeposito(codigoCartera, "Ahorros");

                if (cuentasCliente.Count == 0)
                {
                    MessageBox.Show("No se encontraron cuentas asociadas a esta cartera.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (var cuenta in cuentasCliente)
                {
                    cmbNumeroCuenta.Items.Add($"{cuenta.NumeroProducto} / {cuenta.TipoCuenta}");
                }

                cmbNumeroCuenta.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cuentas destino: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void generacionInformacion(object sender, EventArgs e)
        {
            try
            {
                string valorBusqueda = cmbNumeroCuenta.Text.Split('/')[0].Trim();

                var cuentaEncontrada = cuentasCliente.FirstOrDefault(c => c.NumeroProducto == valorBusqueda);

                if (cuentaEncontrada != null)
                {
                    lblTipoCuentaValor.Text = cuentaEncontrada.TipoCuenta;
                    lblSaldoActualValor.Text = $"$ {cuentaEncontrada.Saldo}";
                }
                else
                {
                    MessageBox.Show("No se encontró la cuenta seleccionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {


            }


        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos
                if (string.IsNullOrWhiteSpace(txtMontoDeposito.Text))
                {
                    MessageBox.Show("Ingrese el monto del depósito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Ingrese una descripción.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string numeroProducto = cmbNumeroCuenta.Text.Split('/')[0].Trim();
                decimal monto = Convert.ToDecimal(txtMontoDeposito.Text.Trim());
                string descripcion = txtDescripcion.Text.Trim();
                string codigoEmpleado = txtCodigoEmpleado.Text.Trim();
                string codigoCartera = txtCodigoCartera.Text.Trim();

                Random rnd = new Random();
                int numeroSecuencial = rnd.Next(1, 999);

                // registrar deposito
                string mensaje = TransaccionesRepositorio.RegistrarDeposito(
                    codigoEmpleado,
                    codigoCartera,
                    monto,
                    descripcion,
                    numeroProducto,
                    numeroSecuencial
                );

                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Refrescar
                CargarCuenstasDestiono(codigoCartera);

                generacionInformacion(sender, e);

                txtMontoDeposito.Clear();
                txtDescripcion.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("El monto ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar depósito: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

    
    