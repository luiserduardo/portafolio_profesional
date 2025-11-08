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

namespace acomprendedoresProyecto.interfaz.transaccion
{
    public partial class RetiroTarjeta : UserControl
    {
        Cliente Cliente = null;
        CarteraVirtual cartera;
        CarteraVirtualRepositorio carteraUsuario = new CarteraVirtualRepositorio();
        ProductosRepositorio productoRepo = new ProductosRepositorio();
        TransaccionesRepositorio TransaccionesRepositorio = new TransaccionesRepositorio();

        // Guarda temporalmente las tarjetas del cliente
        private List<Tarjeta> tarjetasCliente = new List<Tarjeta>();

        public RetiroTarjeta(Cliente cliente)
        {
            InitializeComponent();
            this.Cliente = cliente;

        }

        private void RetiroTarjeta_Load(object sender, EventArgs e)
        {
            if (Cliente == null)
            {
                MessageBox.Show("No se ha cargado la información del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener la cartera del cliente
            cartera = carteraUsuario.ObtenerCarteraPorCliente(Cliente.CodigoUsuario);

            if (cartera == null)
            {
                MessageBox.Show("El cliente no tiene una cartera asociada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            //asignar cartera
            txtCodigoCartera.Text = cartera.CodigoCartera;

            // Cargar las tarjetas del cliente
            CargarTarjetasCliente(cartera.CodigoCartera);
            // Cargar las cuentas
            CargarTarjetasCliente(cartera.CodigoCartera);




        }

        private void CargarTarjetasCliente(string codigoCartera)
        {
            try
            {
                cmbTarjetas.Items.Clear();

                // Recuperar tarjetas de la cartera
                tarjetasCliente = productoRepo.RecuperarTarjetasCartera(codigoCartera);

                if (tarjetasCliente == null || tarjetasCliente.Count == 0)
                {
                    MessageBox.Show("No se encontraron tarjetas asociadas a esta cartera.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Las tarjetas 
                foreach (var tarjeta in tarjetasCliente)
                {
                    cmbTarjetas.Items.Add($"{tarjeta.NumeroTarjeta} / {tarjeta.TipoTarjeta}");
                }

                if (cmbTarjetas.Items.Count > 0)
                {
                    cmbTarjetas.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tarjetas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void generarInformacion(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmbTarjetas.Text) || cmbTarjetas.SelectedIndex < 0)
                {
                    return;
                }

                string[] partes = cmbTarjetas.Text.Split('/');
                if (partes.Length < 2)
                {
                    return;
                }

                string valorBusqueda = partes[0].Trim();

                var tarjetaEncontrada = tarjetasCliente.FirstOrDefault(t => t.NumeroTarjeta == valorBusqueda);

                if (tarjetaEncontrada != null)
                {
                    lblTipoCuentaValor.Text = $"{tarjetaEncontrada.TipoTarjeta} - {tarjetaEncontrada.Categoria}";
                    lblSaldoActualValor.Text = $"$ {tarjetaEncontrada.MontoDisponible:N2}";

                    tiporedlda.Text = $"$ {tarjetaEncontrada.TipoRed}";
                }
                else
                {
                    lblTipoCuentaValor.Text = "-";
                    lblSaldoActualValor.Text = "$0.00";
                    tiporedlda.Text = "00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar información de la tarjeta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos
                if (cmbTarjetas.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione una tarjeta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtMonto.Text))
                {
                    MessageBox.Show("Ingrese el monto a retirar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal monto;
                if (!decimal.TryParse(txtMonto.Text.Trim(), out monto))
                {
                    MessageBox.Show("El monto ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (monto <= 0)
                {
                    MessageBox.Show("El monto debe ser mayor a cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener datos de la tarjeta seleccionada
                string[] partes = cmbTarjetas.Text.Split('/');
                if (partes.Length < 2)
                {
                    MessageBox.Show("Formato de tarjeta inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string numeroTarjeta = partes[0].Trim();
                var tarjetaSeleccionada = tarjetasCliente.FirstOrDefault(t => t.NumeroTarjeta == numeroTarjeta);

                if (tarjetaSeleccionada == null)
                {
                    MessageBox.Show("No se pudo identificar la tarjeta seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar que haya saldo disponible
                if (monto > Convert.ToDecimal(tarjetaSeleccionada.MontoDisponible))
                {
                    MessageBox.Show($"Saldo insuficiente. Monto disponible: ${tarjetaSeleccionada.MontoDisponible:N2}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string numeroProducto = tarjetaSeleccionada.NumeroProducto;
                string tipoTarjeta = tarjetaSeleccionada.TipoTarjeta;
                string codigoCartera = cartera.CodigoCartera;

                // Generar número secuencial aleatorio
                Random rnd = new Random();
                int numeroSecuencial = rnd.Next(1, 999);

                // Confirmar retiro
                DialogResult resultado = MessageBox.Show(
                    $"¿Está seguro de retirar ${monto:N2} de la tarjeta {numeroTarjeta}?",
                    "Confirmar Retiro",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado != DialogResult.Yes)
                {
                    return;
                }

                // Ejecutar retiro
                string mensaje = TransaccionesRepositorio.RetirarDineroTarjeta(
                    numeroProducto,
                    monto,
                    tipoTarjeta,
                    "Retiro dinero",
                    codigoCartera,
                    numeroSecuencial,
                    null  
                );

                MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Si el retiro fue exitoso, refrescar datos
                if (mensaje.Contains("exitosa") || mensaje.Contains("correcta"))
                {
                    // Refrescar datos
                    CargarTarjetasCliente(codigoCartera);
                    generarInformacion(sender, e);

                    // Limpiar campos
                    txtMonto.Clear();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El monto ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar retiro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
