using System;
using System.Linq;
using System.Windows.Forms;
using acomprendedoresProyecto.clases;
using acomprendedoresProyecto.interfaz.reporte;
using acomprendedoresProyecto.repositorios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace acomprendedoresProyecto.pantallas.clientesYproductos.seleccionCliente
{
    public partial class Detalle : Form
    {
        private Cliente cliente;
        private ProductosRepositorio productosRepositorio = new ProductosRepositorio();
        private UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        private TransaccionesRepositorio transaccionesRepositorio = new TransaccionesRepositorio();
        string codigoCartera = null;

        public Detalle(object objetoCliente)
        {
            InitializeComponent();

            dgvTarjetas.DataError += dgvTarjetas_DataError;
            dgvCuentas.DataError += dgvCuentas_DataError;
            dgvPrestamos.DataError += dgvPrestamos_DataError;
            dvTransacciones.DataError += dvTransacciones_DataError;

            CargarCliente(objetoCliente);
        }

        private void CargarCliente(object objetoCliente)
        {
            string codigoUsuario = ObtenerPropiedad(objetoCliente, "CodigoUsuario");

            if (string.IsNullOrEmpty(codigoUsuario))
            {
                MostrarError("No se pudo obtener el código del usuario.");
                return;
            }

            cliente = usuarioRepositorio.ObtenerClientePorCodigo(codigoUsuario);

            if (cliente == null)
            {
                MostrarError("No se pudo cargar la información del cliente.");
                return;
            }

            codigoCartera = ObtenerCodigoCartera(codigoUsuario);
            MostrarDetalleCliente(codigoCartera);
        }

        private string ObtenerPropiedad(object obj, string nombrePropiedad)
        {
            var propiedad = obj?.GetType().GetProperty(nombrePropiedad);
            return propiedad?.GetValue(obj)?.ToString();
        }

        private string ObtenerCodigoCartera(string codigoUsuario)
        {
            var directorio = usuarioRepositorio.ObtenerDirectorioClientes("Activo");
            var clienteDirectorio = directorio.FirstOrDefault(c =>
                ObtenerPropiedad(c, "CodigoUsuario") == codigoUsuario);

            return ObtenerPropiedad(clienteDirectorio, "CodigoCartera");
        }

        private void MostrarDetalleCliente(string codigoCartera)
        {
            // info
            lblClienteNombre.Text = $"{cliente.Nombre} {cliente.Apellido}";
            label3.Text = $"{cliente.CodigoUsuario}";
            label4.Text = $"{cliente.DUI}";
            label5.Text = $"{codigoCartera}";

            // Cargar productos si hay cartera
            if (!string.IsNullOrEmpty(codigoCartera))
            {
                CargarProductos(codigoCartera);
            }
            else
            {
                LimpiarProductos();
            }

            pnlDetallesCliente.Visible = true;
        }

        private void CargarProductos(string codigoCartera)
        {
            try
            {
                ConfigurarTablaTransacciones();

                var cuentas = productosRepositorio.ObtenerCuentas(codigoCartera);
                var prestamos = productosRepositorio.ObtenerPrestamos(codigoCartera);
                var tarjetas = productosRepositorio.ObtenerTarjetas(codigoCartera);

                // Configurar columnas según el tipo de tarjetas
                if (tarjetas != null && tarjetas.Count > 0)
                {
                    var primeraTarjeta = tarjetas[0];
                    if (primeraTarjeta.GetType().Name == "TarjetaCredito")
                    {
                        ConfigurarTablaTarjetasCredito();
                    }
                    else
                    {
                        ConfigurarTablaTarjetasDebito();
                    }
                }
                else
                {
                    ConfigurarTablaTarjetas(); 
                }

                dvTransacciones.DataSource = null;
                dvTransacciones.DataSource = transaccionesRepositorio.ObtenerTransacciones(codigoCartera);

                dgvCuentas.DataSource = cuentas;
                dgvPrestamos.DataSource = prestamos;
                dgvTarjetas.DataSource = tarjetas;

                int totalProductos = (cuentas?.Count ?? 0) +
                                   (prestamos?.Count ?? 0) +
                                   (tarjetas?.Count ?? 0);

                lblProductCount.Text = totalProductos.ToString();
                lblProductsTitle.Text = $"Productos Financieros ({totalProductos})";
            }
            catch (Exception ex)
            {
                MostrarError($"Error al cargar productos: {ex.Message}");
                LimpiarProductos();
            }
        }

        private void LimpiarProductos()
        {
            dgvCuentas.DataSource = null;
            dgvPrestamos.DataSource = null;
            dgvTarjetas.DataSource = null;
            lblProductCount.Text = "0";
            lblProductsTitle.Text = "Productos Financieros (0)";
        }

        private void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ConfigurarTablaTransacciones()
        {
            dvTransacciones.Columns.Clear();
            dvTransacciones.AutoGenerateColumns = false;
            dvTransacciones.DataSource = null;

            dvTransacciones.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Número Producto", DataPropertyName = "NumeroProducto" });
            dvTransacciones.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tipo Transacción", DataPropertyName = "TipoTransaccion" });
            dvTransacciones.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tipo Producto", DataPropertyName = "TipoProducto" });
            dvTransacciones.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Monto", DataPropertyName = "MontoTransaccion" });
            dvTransacciones.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha transacción", DataPropertyName = "FechaTransaccion" });
            dvTransacciones.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Descripción", DataPropertyName = "Descripcion" });
        }

        // Método solo para tarjetas de débito
        private void ConfigurarTablaTarjetasDebito()
        {
            dgvTarjetas.Columns.Clear();
            dgvTarjetas.AutoGenerateColumns = false;
            dgvTarjetas.DataSource = null;

            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Número Producto", DataPropertyName = "NumeroProducto" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Número Tarjeta", DataPropertyName = "NumeroTarjeta" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tipo Tarjeta", DataPropertyName = "TipoTarjeta" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Límite Monto", DataPropertyName = "LimiteMonto" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tipo Red", DataPropertyName = "TipoRed" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Categoría", DataPropertyName = "Categoria" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha Expiración", DataPropertyName = "FechaExpiracion" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha Adquisición", DataPropertyName = "FechaAdquisicion" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha Cierre", DataPropertyName = "FechaCierre" });
        }

        // Método solo para tarjetas de crédito
        private void ConfigurarTablaTarjetasCredito()
        {
            dgvTarjetas.Columns.Clear();
            dgvTarjetas.AutoGenerateColumns = false;
            dgvTarjetas.DataSource = null;

            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Número Producto", DataPropertyName = "NumeroProducto" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Número Tarjeta", DataPropertyName = "NumeroTarjeta" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tipo Tarjeta", DataPropertyName = "TipoTarjeta" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tipo Red", DataPropertyName = "TipoRed" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Categoría", DataPropertyName = "Categoria" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tasa de Interés", DataPropertyName = "TasaInteres" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Costo Membresía", DataPropertyName = "CostoMembresia" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha Expiración", DataPropertyName = "FechaExpiracion" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Límite Crédito", DataPropertyName = "LimiteCredito" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Saldo Utilizado", DataPropertyName = "SaldoUtilizado" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha Corte", DataPropertyName = "FechaCorte" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha Pago", DataPropertyName = "FechaPago" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Pago Mínimo", DataPropertyName = "PagoMinimo" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Saldo Disponible", DataPropertyName = "SaldoDisponible" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha Adquisición", DataPropertyName = "FechaAdquisicion" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha Cierre", DataPropertyName = "FechaCierre" });
        }

        private void ConfigurarTablaTarjetas()
        {
            dgvTarjetas.Columns.Clear();
            dgvTarjetas.AutoGenerateColumns = false;
            dgvTarjetas.DataSource = null;

            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Número Producto", DataPropertyName = "NumeroProducto" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Número Tarjeta", DataPropertyName = "NumeroTarjeta" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tipo Tarjeta", DataPropertyName = "TipoTarjeta" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Límite Monto", DataPropertyName = "LimiteMonto" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tipo Red", DataPropertyName = "TipoRed" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Categoría", DataPropertyName = "Categoria" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tasa de Interés", DataPropertyName = "TasaInteres" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Costo Membresía", DataPropertyName = "CostoMembresia" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha Expiración", DataPropertyName = "FechaExpiracion" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Límite Crédito", DataPropertyName = "LimiteCredito" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Saldo Utilizado", DataPropertyName = "SaldoUtilizado" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha Corte", DataPropertyName = "FechaCorte" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha Pago", DataPropertyName = "FechaPago" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Pago Mínimo", DataPropertyName = "PagoMinimo" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Saldo Disponible", DataPropertyName = "SaldoDisponible" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha Adquisición", DataPropertyName = "FechaAdquisicion" });
            dgvTarjetas.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha Cierre", DataPropertyName = "FechaCierre" });
        }

        private void dgvTarjetas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void dgvCuentas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void dgvPrestamos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void dvTransacciones_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte(codigoCartera);
            reporte.ShowDialog();

        }
    }
}