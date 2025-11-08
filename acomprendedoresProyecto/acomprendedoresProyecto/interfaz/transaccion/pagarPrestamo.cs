using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using acomprendedoresProyecto.clases;
using acomprendedoresProyecto.repositorios;

namespace acomprendedoresProyecto.ui.transaccion
{
    public partial class pagarPrestamo : UserControl
    {
        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        Cliente cliente;
        CarteraVirtual cartera;
        CarteraVirtualRepositorio carteraUsuario = new CarteraVirtualRepositorio();
        ProductosRepositorio productoRepo = new ProductosRepositorio();
        TransaccionesRepositorio TransaccionesRepositorio = new TransaccionesRepositorio();

        //Guardar prestamo temporalmente
        private List<Prestamo> prestamoCliente = new List<Prestamo>();
        private List<Cuenta> cuentasCliente = new List<Cuenta>();

        // Flag para evitar múltiples ejecuciones del Paint
        private bool datosInicializados = false;

        public pagarPrestamo(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        private void CargarCuenstasDestiono(string codigoCartera)
        {
            try
            {
                cmbCuentaPago.Items.Clear();
                cuentasCliente.Clear();

                // Recuperar cuentas Ahorros y Corriente y agregarlas si existen
                var ahorros = productoRepo.RecuperarCuentaDestinoDeposito(codigoCartera, "Ahorros") ?? new List<Cuenta>();
                var corriente = productoRepo.RecuperarCuentaDestinoDeposito(codigoCartera, "Corriente") ?? new List<Cuenta>();

                cuentasCliente.AddRange(ahorros);
                cuentasCliente.AddRange(corriente);

                if (cuentasCliente.Count == 0)
                {
                    MessageBox.Show("No se encontraron cuentas asociadas a esta cartera.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Llenar el combobox con la lista de cuentas
                foreach (var cuenta in cuentasCliente)
                {
                    cmbCuentaPago.Items.Add($"{cuenta.NumeroProducto} / {cuenta.TipoCuenta}");
                }

                cmbCuentaPago.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cuentas destino: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTarjetasCliente(string codigoCartera)
        {
            try
            {
                cmbPrestamo.Items.Clear();
                prestamoCliente.Clear();

                // Recuperar préstamos de la cartera
                prestamoCliente = productoRepo.RecuperarPrestamosCartera(codigoCartera);

                if (prestamoCliente == null || prestamoCliente.Count == 0)
                {
                    MessageBox.Show("No se encontraron préstamos asociados a esta cartera.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Agregar préstamos al combo
                foreach (var prestamo in prestamoCliente)
                {
                    cmbPrestamo.Items.Add($"{prestamo.NumeroProducto} / {prestamo.TipoPrestamo}");
                }

                if (cmbPrestamo.Items.Count > 0)
                {
                    cmbPrestamo.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar préstamos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            // Evitar múltiples ejecuciones
            if (datosInicializados) return;

            if (cliente == null)
            {
                MessageBox.Show("No se ha cargado la información del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener la cartera del cliente
            cartera = carteraUsuario.ObtenerCarteraPorCliente(cliente.CodigoUsuario);

            if (cartera == null)
            {
                MessageBox.Show("El cliente no tiene una cartera asociada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //asignar cartera
            txtCodigoCartera.Text = cartera.CodigoCartera;

            // Cargar las préstamos del cliente
            CargarTarjetasCliente(cartera.CodigoCartera);
            //Cargar las cuentas del cliente
            CargarCuenstasDestiono(cartera.CodigoCartera);

            txtMontoPersonalizado.Enabled = false;

            radioMinimo.CheckedChanged += RadioButtons_CheckedChanged;
            radioCuota.CheckedChanged += RadioButtons_CheckedChanged;
            radioTotal.CheckedChanged += RadioButtons_CheckedChanged;

            // Conectar evento del textbox
            txtMontoPersonalizado.TextChanged += txtMontoPersonalizado_TextChanged;

            // Marcar como inicializado
            datosInicializados = true;
        }

        //Evento del combo de préstamo
        private void prestamo(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmbPrestamo.Text) || cmbPrestamo.SelectedIndex < 0)
                {
                    LimpiarDetallesPrestamo();
                    return;
                }

                string[] partes = cmbPrestamo.Text.Split('/');
                if (partes.Length < 2)
                {
                    LimpiarDetallesPrestamo();
                    return;
                }

                string valorBusqueda = partes[0].Trim();

                var prestamoEncontrado = prestamoCliente.FirstOrDefault(p => p.NumeroProducto == valorBusqueda);

                if (prestamoEncontrado != null)
                {
                    // Mostrar detalles del préstamo
                    lblTipoPrestamoValor.Text = prestamoEncontrado.TipoPrestamo;
                    lblMontoOriginalValor.Text = $"${prestamoEncontrado.MontoOtorgado:N2}";
                    lblSaldoPendienteValor.Text = $"${prestamoEncontrado.SaldoPendiente:N2}";

                    lblCuotaMensualValor.Text = $"${prestamoEncontrado.Cuota:N2}";
                    lblFechaLimiteValor.Text = prestamoEncontrado.FechaLimitePago.ToString("dd/MM/yyyy");
                    lblTasaInteresValor.Text = $"{prestamoEncontrado.TasaInteres}%";

                    // Actualizar los valores de los radio buttons
                    lblMinimoMonto.Text = $"${prestamoEncontrado.Cuota:N2}";
                    lblCuotaMonto.Text = $"${prestamoEncontrado.Cuota:N2}";
                    lblTotalMonto.Text = $"${prestamoEncontrado.SaldoPendiente:N2}";

                    // Mostrar paneles
                    panelInfoPrestamo.Visible = true;
                    panelOpcionesPago.Visible = true;
                    lblOpcionesPago.Visible = true;
                    panelMontoDisplay.Visible = true;

                    // Seleccionar pago mínimo por defecto
                    radioMinimo.Checked = true;

                    // Actualizar el monto a pagar
                    ActualizarMontoAPagar();
                }
                else
                {
                    LimpiarDetallesPrestamo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar información del préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarDetallesPrestamo();
            }
        }

        private void ActualizarMontoAPagar()
        {
            try
            {
                if (cmbPrestamo.SelectedIndex < 0)
                {
                    lblMontoValor.Text = "$0.00";
                    return;
                }

                string[] partes = cmbPrestamo.Text.Split('/');
                string numeroProducto = partes[0].Trim();
                var prestamoSeleccionado = prestamoCliente.FirstOrDefault(p => p.NumeroProducto == numeroProducto);

                if (prestamoSeleccionado == null)
                {
                    lblMontoValor.Text = "$0.00";
                    return;
                }

                decimal monto = 0;

                if (radioMinimo.Checked)
                {
                    monto = (decimal)prestamoSeleccionado.Cuota;
                }
                else if (radioCuota.Checked)
                {
                    monto = (decimal)prestamoSeleccionado.Cuota;
                }
                else if (radioTotal.Checked)
                {
                    monto = (decimal)prestamoSeleccionado.SaldoPendiente;
                }
                else if (radioOtro.Checked)
                {
                    if (!string.IsNullOrWhiteSpace(txtMontoPersonalizado.Text))
                    {
                        decimal.TryParse(txtMontoPersonalizado.Text.Trim(), out monto);
                    }
                }

                lblMontoValor.Text = $"${monto:N2}";
            }
            catch (Exception ex)
            {
                lblMontoValor.Text = "$0.00";
            }
        }

        private void LimpiarDetallesPrestamo()
        {
            lblTipoPrestamoValor.Text = "-";
            lblMontoOriginalValor.Text = "$0.00";
            lblSaldoPendienteValor.Text = "$0.00";
            lblCuotaMensualValor.Text = "$0.00";
            lblFechaLimiteValor.Text = "-";
            lblTasaInteresValor.Text = "0.00%";

            lblMinimoMonto.Text = "$0.00";
            lblCuotaMonto.Text = "$0.00";
            lblTotalMonto.Text = "$0.00";

            txtMontoPersonalizado.Enabled = false;
            txtMontoPersonalizado.Clear();

            panelInfoPrestamo.Visible = false;
            panelOpcionesPago.Visible = false;
            lblOpcionesPago.Visible = false;
            panelMontoDisplay.Visible = false;
            panelMontoPersonalizado.Visible = false;

            lblMontoValor.Text = "$0.00";
        }

        private void btnRealizarPago_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se haya seleccionado un préstamo
                if (cmbPrestamo.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione un préstamo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que se haya seleccionado una cuenta
                if (cmbCuentaPago.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione una cuenta para realizar el pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar que se haya seleccionado una opción de pago
                if (!radioMinimo.Checked && !radioCuota.Checked && !radioTotal.Checked && !radioOtro.Checked)
                {
                    MessageBox.Show("Seleccione una opción de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string[] partesPrestamo = cmbPrestamo.Text.Split('/');
                string numeroProductoPrestamo = partesPrestamo[0].Trim();
                var prestamoSeleccionado = prestamoCliente.FirstOrDefault(p => p.NumeroProducto == numeroProductoPrestamo);

                if (prestamoSeleccionado == null)
                {
                    MessageBox.Show("No se pudo identificar el préstamo seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener datos de la cuenta seleccionada
                string[] partesCuenta = cmbCuentaPago.Text.Split('/');
                string numeroProductoCuenta = partesCuenta[0].Trim();
                string tipoCuenta = partesCuenta[1].Trim();

                // Calcular el monto a pagar según la opción seleccionada
                decimal montoPago = 0;
                string opcionPago = "";

                if (radioMinimo.Checked || radioCuota.Checked)
                {
                    montoPago = (decimal)prestamoSeleccionado.Cuota;
                    opcionPago = "Pago mínimo";
                }
                else if (radioTotal.Checked)
                {
                    montoPago = (decimal)prestamoSeleccionado.SaldoPendiente;
                    opcionPago = "Pago total";
                }
                else if (radioOtro.Checked)
                {
                    if (string.IsNullOrWhiteSpace(txtMontoPersonalizado.Text))
                    {
                        MessageBox.Show("Ingrese el monto a pagar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!decimal.TryParse(txtMontoPersonalizado.Text.Trim(), out montoPago))
                    {
                        MessageBox.Show("El monto ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (montoPago <= 0)
                    {
                        MessageBox.Show("El monto debe ser mayor a cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Validar que el monto sea mayor o igual a la cuota mínima
                    if (montoPago < (decimal)prestamoSeleccionado.Cuota)
                    {
                        MessageBox.Show($"El monto no puede ser menor al pago mínimo: ${prestamoSeleccionado.Cuota:N2}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Validar que no se pague más del saldo pendiente
                    if (montoPago > (decimal)prestamoSeleccionado.SaldoPendiente)
                    {
                        MessageBox.Show($"El monto no puede ser mayor al saldo pendiente: ${prestamoSeleccionado.SaldoPendiente:N2}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    opcionPago = "Otro monto";
                }

                string codigoCartera = cartera.CodigoCartera;

                // Generar número secuencial aleatorio
                Random rnd = new Random();
                int numeroSecuencial = rnd.Next(1, 999);

                // Confirmar pago
                DialogResult resultado = MessageBox.Show(
                    $"¿Está seguro de realizar el pago de ${montoPago:N2} al préstamo {prestamoSeleccionado.TipoPrestamo}?\n\n" +
                    $"Se descontará de la cuenta: {tipoCuenta}",
                    "Confirmar Pago",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado != DialogResult.Yes)
                {
                    return;
                }

                // Ejecutar pago
                string mensaje = TransaccionesRepositorio.PagarPrestamo(
                    numeroProductoPrestamo,
                    numeroProductoCuenta,
                    montoPago,
                    tipoCuenta,
                    codigoCartera,
                    $"Pago de préstamo - {opcionPago}",
                    numeroSecuencial
                );

                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Si el pago fue exitoso, refrescar datos
                if (mensaje.Contains("exitosa") || mensaje.Contains("éxito"))
                {
                    // Refrescar datos
                    CargarTarjetasCliente(codigoCartera);
                    CargarCuenstasDestiono(codigoCartera);

                    // Limpiar campos
                    txtMontoPersonalizado.Clear();

                    // Si aún hay , seleccionar el primero
                    if (cmbPrestamo.Items.Count > 0)
                    {
                        cmbPrestamo.SelectedIndex = 0;
                        radioMinimo.Checked = true;
                    }
                    else
                    {
                        LimpiarDetallesPrestamo();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El monto ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioOtro_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOtro.Checked)
            {
                txtMontoPersonalizado.Enabled = true;
                panelMontoPersonalizado.Visible = true;
                txtMontoPersonalizado.Focus();
            }
            else
            {
                txtMontoPersonalizado.Enabled = false;
                panelMontoPersonalizado.Visible = false;
                txtMontoPersonalizado.Clear();
            }

            ActualizarMontoAPagar();
        }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            // Controlar visibilidad del 
            if (radioOtro.Checked)
            {
                panelMontoPersonalizado.Visible = true;
                txtMontoPersonalizado.Enabled = true;
            }
            else
            {
                panelMontoPersonalizado.Visible = false;
                txtMontoPersonalizado.Enabled = false;
                txtMontoPersonalizado.Clear();
            }

            ActualizarMontoAPagar();
        }

        private void txtMontoPersonalizado_TextChanged(object sender, EventArgs e)
        {
            ActualizarMontoAPagar();
        }
    }
}