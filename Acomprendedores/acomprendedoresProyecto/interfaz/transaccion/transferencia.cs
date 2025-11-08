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
    public partial class transferencia : UserControl
    {

        //Repositorios
        private UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        private CarteraVirtualRepositorio carteraUsuario = new CarteraVirtualRepositorio();
        private ProductosRepositorio productoRepo = new ProductosRepositorio();
        private TransaccionesRepositorio transaccionesRepo = new TransaccionesRepositorio();

        private Cliente cliente;
        private CarteraVirtual cartera;
        private List<Cuenta> cuentasOrigen = new List<Cuenta>();
        private List<Cuenta> cuentasDestino = new List<Cuenta>();

        private string codigoCarteraDestino = string.Empty;
        private string nombreCompletoDestino = string.Empty;

        private bool datosInicializados = false;

        public transferencia(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        private void transferencia_Load(object sender, EventArgs e)
        {
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            if (datosInicializados) return;

            if (cliente == null)
            {
                MessageBox.Show("No se ha cargado la información del cliente.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener cartera del cliente
            cartera = carteraUsuario.ObtenerCarteraPorCliente(cliente.CodigoUsuario);

            if (cartera == null)
            {
                MessageBox.Show("El cliente no tiene una cartera asociada.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtCodigoCartera.Text = cartera.CodigoCartera;

            CargarCuentasOrigen();

            LimpiarPanelDestino();

            // Ocultar panel de información de destino al inicio
            if (groupBoxInfoDestino != null)
                groupBoxInfoDestino.Visible = false;

            // Ocultar panel de monto display al inicio
            if (panelMontoDisplay != null)
                panelMontoDisplay.Visible = false;

            // Configurar placeholder
            ConfigurarTextboxBuscar();

            // Asignar eventos
            txtBuscar.KeyPress += TxtBuscarCuenta_KeyPress;
            txtBuscar.Enter += TxtBuscar_Enter;
            txtBuscar.Leave += TxtBuscar_Leave;
            btnBuscar.Click += BtnBuscar_Click; 
            cmbCuentaDestino.SelectedIndexChanged += CmbCuentaDestino_SelectedIndexChanged;
            txtMonto.TextChanged += TxtMonto_TextChanged;
            btnTransferir.Click += BtnTransferir_Click;

            datosInicializados = true;
        }

        private void ConfigurarTextboxBuscar()
        {
            if (string.IsNullOrEmpty(txtBuscar.Text) || txtBuscar.Text == "Buscar por código o DUI ...")
            {
                txtBuscar.Text = "Buscar por código o DUI ...";
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void TxtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar por código o DUI ...")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void TxtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = "Buscar por código o DUI ...";
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCuentaDestino();
        }

        private void CargarCuentasOrigen()
        {
            try
            {
                cmbCuentaOrigen.Items.Clear();
                cuentasOrigen.Clear();

                // Recuperar cuentas Ahorros y Corriente
                var ahorros = productoRepo.RecuperarCuentaDestinoDeposito(cartera.CodigoCartera, "Ahorros")
                    ?? new List<Cuenta>();
                var corriente = productoRepo.RecuperarCuentaDestinoDeposito(cartera.CodigoCartera, "Corriente")
                    ?? new List<Cuenta>();

                cuentasOrigen.AddRange(ahorros);
                cuentasOrigen.AddRange(corriente);

                if (cuentasOrigen.Count == 0)
                {
                    MessageBox.Show("No tiene cuentas disponibles para transferir.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Llenar combobox
                foreach (var cuenta in cuentasOrigen)
                {
                    cmbCuentaOrigen.Items.Add($"{cuenta.NumeroProducto} / {cuenta.TipoCuenta}");
                }

                cmbCuentaOrigen.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cuentas de origen: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtBuscarCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BuscarCuentaDestino();
            }
        }

        private void BuscarCuentaDestino()
        {
            string codigoUsuarioBusqueda = txtBuscar.Text.Trim();

            // Validar que no sea el placeholder
            if (string.IsNullOrEmpty(codigoUsuarioBusqueda) || codigoUsuarioBusqueda == "Buscar por código o DUI ...")
            {
                MessageBox.Show("Ingrese un código de usuario para buscar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuscar.Focus();
                return;
            }

            // Validar que no sea el mismo usuario
            if (codigoUsuarioBusqueda == cliente.CodigoUsuario)
            {
                MessageBox.Show("No puede transferir a sus propias cuentas desde aquí.\n" +
                              "Use la opción de 'Transferencia entre mis cuentas'.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuscar.Clear();
                ConfigurarTextboxBuscar();
                txtBuscar.Focus();
                return;
            }

            try
            {
                string mensaje;
                cuentasDestino = productoRepo.BuscarCuentaDestino(codigoUsuarioBusqueda, out mensaje);

                if (cuentasDestino == null || cuentasDestino.Count == 0)
                {
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarPanelDestino();
                    return;
                }

                // Obtener información del destinatario de la primera cuenta
                codigoCarteraDestino = cuentasDestino[0].CodigoCartera;

                // Buscar info completa del usuario
                Usuario usuarioDestino = usuarioRepositorio.ObtenerUsuarioPorCodigo(codigoUsuarioBusqueda);

                if (usuarioDestino != null)
                {
                    nombreCompletoDestino = $"{usuarioDestino.Nombre} {usuarioDestino.Apellido}";

                    // Mostrar info
                    lblTitularDestinoValor.Text = nombreCompletoDestino;
                    lblNumeroCuentaDestinoValor.Text = codigoUsuarioBusqueda;
                    lblTipoCuentaDestinoValor.Text = cuentasDestino.Count > 1
                        ? $"{cuentasDestino.Count} cuentas disponibles"
                        : cuentasDestino[0].TipoCuenta;

                    // Cargar cuentas destino 
                    cmbCuentaDestino.Items.Clear();
                    foreach (var cuenta in cuentasDestino)
                    {
                        cmbCuentaDestino.Items.Add($"{cuenta.NumeroProducto} / {cuenta.TipoCuenta}");
                    }
                    cmbCuentaDestino.SelectedIndex = 0;

                    // Mostrar el panel de información de destino
                    if (groupBoxInfoDestino != null)
                        groupBoxInfoDestino.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar cuenta destino: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarPanelDestino();
            }
        }

        private void LimpiarPanelDestino()
        {
            cmbCuentaDestino.Items.Clear();
            cuentasDestino.Clear();

            if (lblTitularDestinoValor != null) lblTitularDestinoValor.Text = "-";
            if (lblNumeroCuentaDestinoValor != null) lblNumeroCuentaDestinoValor.Text = "-";
            if (lblTipoCuentaDestinoValor != null) lblTipoCuentaDestinoValor.Text = "-";

            codigoCarteraDestino = string.Empty;
            nombreCompletoDestino = string.Empty;

            if (groupBoxInfoDestino != null)
                groupBoxInfoDestino.Visible = false;

            ActualizarMontoTransferir();
        }

       
        private void CmbCuentaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarMontoTransferir();
        }

        private void TxtMonto_TextChanged(object sender, EventArgs e)
        {
            ActualizarMontoTransferir();
        }

        private void ActualizarMontoTransferir()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMonto.Text) ||
                    !decimal.TryParse(txtMonto.Text.Trim(), out decimal monto))
                {
                    lblMontoDisplayValor.Text = "$0.00";
                    if (panelMontoDisplay != null)
                        panelMontoDisplay.Visible = false;
                    return;
                }

                // Comisión fija de $0.50
                decimal comision = 0.50m;
                decimal total = monto + comision;

                lblMontoDisplayValor.Text = $"${total:N2}";

                // Mostrar el panel de monto
                if (panelMontoDisplay != null)
                    panelMontoDisplay.Visible = true;
            }
            catch
            {
                lblMontoDisplayValor.Text = "$0.00";
                if (panelMontoDisplay != null)
                    panelMontoDisplay.Visible = false;
            }
        }

        private void BtnTransferir_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCuentaOrigen.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione una cuenta de origen.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbCuentaOrigen.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(codigoCarteraDestino) || cmbCuentaDestino.SelectedIndex < 0)
                {
                    MessageBox.Show("Busque y seleccione una cuenta de destino.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBuscar.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtMonto.Text))
                {
                    MessageBox.Show("Ingrese el monto a transferir.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMonto.Focus();
                    return;
                }

                if (!decimal.TryParse(txtMonto.Text.Trim(), out decimal montoTransferencia))
                {
                    MessageBox.Show("El monto ingresado no es válido.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMonto.Clear();
                    txtMonto.Focus();
                    return;
                }

                if (montoTransferencia <= 0)
                {
                    MessageBox.Show("El monto debe ser mayor a cero.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMonto.Clear();
                    txtMonto.Focus();
                    return;
                }

                // Obtener cuentas seleccionadas
                string[] partesOrigen = cmbCuentaOrigen.Text.Split('/');
                string numeroProductoOrigen = partesOrigen[0].Trim();

                string[] partesDestino = cmbCuentaDestino.Text.Split('/');
                string numeroProductoDestino = partesDestino[0].Trim();

                // Validar saldo suficiente
                var cuentaOrigen = cuentasOrigen.FirstOrDefault(c => c.NumeroProducto == numeroProductoOrigen);
               
                
                if (cuentaOrigen == null)
                {
                    MessageBox.Show("Error al obtener información de la cuenta de origen.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal comision = 0.50m;
                decimal montoTotal = montoTransferencia + comision;

                if ((decimal)cuentaOrigen.Saldo < montoTotal)
                {
                    MessageBox.Show($"Saldo insuficiente.\n\n" +
                                  $"Necesita: ${montoTotal:N2} (incluye ${comision:N2} de comisión)\n" +
                                  $"Disponible: ${cuentaOrigen.Saldo:N2}",
                        "Saldo Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener descripción
                string descripcion = string.IsNullOrWhiteSpace(txtDescripcion.Text)
                    ? "Transferencia"
                    : txtDescripcion.Text.Trim();

                // Confirmar operación
                DialogResult resultado = MessageBox.Show(
                    $"¿Confirmar transferencia?\n\n" +
                    $"De: {cuentaOrigen.TipoCuenta} ({numeroProductoOrigen})\n" +
                    $"Para: {nombreCompletoDestino}\n" +
                    $"Cuenta: {partesDestino[1].Trim()} ({numeroProductoDestino})\n\n" +
                    $"Monto: ${montoTransferencia:N2}\n" +
                    $"Comisión: ${comision:N2}\n" +
                    $"Total a debitar: ${montoTotal:N2}",
                    "Confirmar Transferencia",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado != DialogResult.Yes)
                {
                    return;
                }

                // Generar número secuencial único
                int numeroSecuencial = GenerarNumeroSecuencial();

                // Ejecutar transferencia
                string mensaje = transaccionesRepo.RealizarTransferencia(
                    cartera.CodigoCartera,
                    codigoCarteraDestino,
                    numeroProductoOrigen,
                    numeroProductoDestino,
                    montoTransferencia,
                    descripcion,
                    numeroSecuencial
                );

                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Si fue exitosa, refrescar datos
                if (mensaje.Contains("exitosa") || mensaje.Contains("éxito"))
                {
                    // Refrescar cuentas de origen
                    CargarCuentasOrigen();

                    // Limpiar controles
                    txtMonto.Clear();
                    txtDescripcion.Clear();
                    txtBuscar.Clear();
                    ConfigurarTextboxBuscar();
                    LimpiarPanelDestino();

                    // Volver a seleccionar primera cuenta origen
                    if (cmbCuentaOrigen.Items.Count > 0)
                    {
                        cmbCuentaOrigen.SelectedIndex = 0;
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El monto ingresado no es válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la transferencia: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private int GenerarNumeroSecuencial()
        {
            DateTime ahora = DateTime.Now;
            int secuencial = (ahora.Hour * 3600 + ahora.Minute * 60 + ahora.Second) % 999;

            // Si es 0, usar 1
            if (secuencial == 0)
                secuencial = 1;

            return secuencial;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbCuentaOrigen_SelectedIndexChanged_1(object sender, EventArgs e)
        {




            if (cmbCuentaOrigen.SelectedIndex < 0) return;

            try
            {
                string[] partes = cmbCuentaOrigen.Text.Split('/');
                string numeroProducto = partes[0].Trim();



                var cuentaSeleccionada = cuentasOrigen.FirstOrDefault(c => c.NumeroProducto == numeroProducto);

                if (cuentaSeleccionada != null)
                {
                    lblTipoOrigenValor.Text = cuentaSeleccionada.TipoCuenta;
                    lblSaldoOrigenValor.Text = $"${cuentaSeleccionada.Saldo:N2}";

                    if (groupBoxInfoOrigen != null)
                        groupBoxInfoOrigen.Visible = true;
                }
            }
            catch (Exception)
            {
                lblTipoOrigenValor.Text = "-";
                lblSaldoOrigenValor.Text = "$0.00";
            }

            ActualizarMontoTransferir();

        }
    }
}