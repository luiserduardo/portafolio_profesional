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
    public partial class retirarCuenta : UserControl
    {
        CarteraVirtual cartera = null;
        CarteraVirtualRepositorio carteraUsuario = new CarteraVirtualRepositorio();
        ProductosRepositorio productoRepo = new ProductosRepositorio();
        TransaccionesRepositorio TransaccionesRepositorio = new TransaccionesRepositorio();


        //Guarda temporarlament cuenta actual
        private List<Cuenta> cuentasCliente = new List<Cuenta>();
        Cuenta cuenta = null;
        public retirarCuenta(Cliente cliente)
        {
            InitializeComponent();

            this.cartera = carteraUsuario.ObtenerCarteraPorCliente(cliente.CodigoUsuario);


            cartera = carteraUsuario.ObtenerCarteraPorCliente(cliente.CodigoUsuario);

            //si no hay problemas y si devuelve algo cartera
            CargarCuenstasDestiono(cartera.CodigoCartera);

        }


        private void CargarCuenstasDestiono(string codigoCartera)
        {
            try
            {
                cmbCuentaOrigen.Items.Clear();

                //   Ahorros
                var cuentasAhorros = productoRepo.RecuperarCuentaDestinoDeposito(codigoCartera, "Ahorros");

                //   Corriente
                var cuentasCorriente = productoRepo.RecuperarCuentaDestinoDeposito(codigoCartera, "Corriente");

                // Combinar
                cuentasCliente = cuentasAhorros.Concat(cuentasCorriente).ToList();

                if (cuentasCliente.Count == 0)
                {
                    MessageBox.Show("No se encontraron cuentas asociadas a esta cartera.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (var cuenta in cuentasCliente)
                {
                    cmbCuentaOrigen.Items.Add($"{cuenta.NumeroProducto} / {cuenta.TipoCuenta}");
                }

                cmbCuentaOrigen.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cuentas destino: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void retirar_Load(object sender, EventArgs e)
        {

        }

        private void generacionInformacion(object sender, EventArgs e)
        {
            try {
                string valorBusqueda = cmbCuentaOrigen.Text.Split('/')[0].Trim();

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

        private void Regirar_Click(object sender, EventArgs e)
        {

            try
            {
                // Validar que haya una cuenta seleccionada
                if (cmbCuentaOrigen.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione una cuenta.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                if (string.IsNullOrWhiteSpace(txtMontoRetiro.Text))
                {
                    MessageBox.Show("Por favor, ingrese el monto a retirar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMontoRetiro.Focus();
                    return;
                }

                // Validar que el monto sea válido
                if (!decimal.TryParse(txtMontoRetiro.Text, out decimal montoRetiro) || montoRetiro <= 0)
                {
                    MessageBox.Show("Por favor, ingrese un monto válido mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   txtMontoRetiro.Focus();
                    return;
                }

                // Obtener la cuenta seleccionada
                string valorBusqueda = cmbCuentaOrigen.Text.Split('/')[0].Trim();
                var cuentaSeleccionada = cuentasCliente.FirstOrDefault(c => c.NumeroProducto == valorBusqueda);

                if (cuentaSeleccionada == null)
                {
                    MessageBox.Show("No se encontró la cuenta seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar que haya saldo suficiente
                if (montoRetiro > (decimal)cuentaSeleccionada.Saldo)
                {
                    MessageBox.Show("Saldo insuficiente para realizar el retiro.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string descripcion = string.IsNullOrWhiteSpace(txtDescripcion.Text)
                    ? "Retiro de cuenta"
                    : txtDescripcion.Text.Trim();

                Random random = new Random();
                int numeroSecuencial = random.Next(1, 1000);

                string mensaje = TransaccionesRepositorio.RetirarDIneroCuenta(
                    cuentaSeleccionada.NumeroProducto,
                    montoRetiro,
                    cuentaSeleccionada.TipoCuenta,
                    descripcion,
                    cartera.CodigoCartera,
                    numeroSecuencial
                );

                if (mensaje.Contains("exitosamente") || mensaje.Contains("éxito") || mensaje.Contains("correctamente"))
                {
                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarCuenstasDestiono(cartera.CodigoCartera);
                    generacionInformacion(null, null);

                    txtMontoRetiro.Clear();
                    if (txtDescripcion != null)
                        txtDescripcion.Clear();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar el retiro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
