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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace acomprendedoresProyecto.pantallas.asesorVentas.consultarCartera
{
    public partial class consultarCartera : UserControl
    {
        //instancia repositorios
        CarteraVirtualRepositorio CarteraVirtualRepositorio = new CarteraVirtualRepositorio();
        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        ProductosRepositorio productosRepositorio = new ProductosRepositorio();
        TransaccionesRepositorio transaccionesRepositorio = new TransaccionesRepositorio();
        Cliente cliente = null;
        CarteraVirtual cartera= null;

        public consultarCartera()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            cliente = null;
            cartera = null;

            lblCodigoValor.Text = "-";
            lblNombreValor.Text = "-";
            lblCodigoCarteraValor.Text = "-";
            lblDUIValor.Text = "-";
            lblCorreoValor.Text = "-";
            lblTelefonoValor.Text = "-";

            panelInfoCliente.Visible = false;
            panelProductos.Visible = false;

            tabla.DataSource = null;
            tabla.Columns.Clear();

            cliente = usuarioRepositorio.ObtenerClientePorCodigoDUI(txtBuscar.Text);

            if (cliente != null)
            {
                cartera = CarteraVirtualRepositorio.ObtenerCarteraPorCliente(cliente.CodigoUsuario);
            }
            else
            {
                cartera = null;
            }


            if (cliente != null && cartera != null)
            {
                panelInfoCliente.Visible = true;
                panelProductos.Visible = true;

                lblCodigoValor.Text = cliente.CodigoUsuario;
                lblNombreValor.Text = cliente.Nombre;
                lblCodigoCarteraValor.Text = cartera.CodigoCartera;
                lblDUIValor.Text = cliente.DUI;
                lblCorreoValor.Text = cliente.CorreoElectronico;
                lblTelefonoValor.Text = cliente.Telefono;
            }

        }


        private void ordenarTablaCUenta()
        {
            tabla.AutoGenerateColumns = false;
            tabla.Columns.Clear();

            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Número Cuenta", DataPropertyName = "NumeroProducto" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tipo Cuenta", DataPropertyName = "TipoCuenta" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha Adquisición", DataPropertyName = "FechaAdquisicion" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha Cierre", DataPropertyName = "FechaCierre" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Saldo", DataPropertyName = "Saldo" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Estado", DataPropertyName = "Estado" });
      

        }

        private void btnCuentas_Click(object sender, EventArgs e)
        {
            ordenarTablaCUenta();
            tabla.DataSource = null;
            tabla.DataSource = productosRepositorio.ObtenerCuentas(cartera.CodigoCartera);

        }


        private void generarTablaPrestamos()
        {
            tabla.AutoGenerateColumns = false;
            tabla.Columns.Clear();

            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Número Producto", DataPropertyName = "NumeroProducto" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tipo Prestamo", DataPropertyName = "TipoPrestamo" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Monto Otorgado", DataPropertyName = "MontoOtorgado" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Saldo Pendiente", DataPropertyName = "SaldoPendiente" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Plazo Meses", DataPropertyName = "PlazoMeses" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Cuota", DataPropertyName = "Cuota" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha Limite Pago", DataPropertyName = "FechaLimitePago" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tasa Interes", DataPropertyName = "TasaInteres" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Cuota Seguro", DataPropertyName = "CuotaSeguro" });

            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Valor Propiedad", DataPropertyName = "ValorPropiedad" }); 
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tipo Propiedad", DataPropertyName = "TipoPropiedad" });   
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Dirección Propiedad", DataPropertyName = "DireccionPropiedad" }); 

            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tipo Actividad", DataPropertyName = "TipoActividad" }); 
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Descripción Actividad", DataPropertyName = "DescripcionActividad" }); 

            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Número Referencia", DataPropertyName = "NumeroReferencia" });

            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha Adquisición", DataPropertyName = "FechaAdquisicion" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha Cierre", DataPropertyName = "FechaCierre" });
        }


        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            generarTablaPrestamos();

            tabla.DataSource = null;
            tabla.DataSource = productosRepositorio.ObtenerPrestamos(cartera.CodigoCartera);

        }


        private void generarTablaTarjetas()
        {
            tabla.Columns.Clear();
            tabla.AutoGenerateColumns = false;

            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Número Producto", DataPropertyName = "NumeroProducto" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Número Tarjeta", DataPropertyName = "NumeroTarjeta" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tipo Tarjeta", DataPropertyName = "TipoTarjeta" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Límite Monto", DataPropertyName = "LimiteMonto" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tipo Red", DataPropertyName = "TipoRed" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Categoría", DataPropertyName = "Categoria" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tasa Interes", DataPropertyName = "TasaInteres" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Costo Membresía", DataPropertyName = "CostoMembresia" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha Expiración", DataPropertyName = "FechaExpiracion" });

            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Límite Crédito", DataPropertyName = "LimiteCredito" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Saldo Utilizado", DataPropertyName = "SaldoUtilizado" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha Corte", DataPropertyName = "FechaCorte" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha Pago", DataPropertyName = "FechaPago" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Pago Mínimo", DataPropertyName = "PagoMinimo" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Saldo Disponible", DataPropertyName = "SaldoDisponible" });

            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha Adquisición", DataPropertyName = "FechaAdquisicion" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha Cierre", DataPropertyName = "FechaCierre" });

        }
        private void btnTarjetas_Click(object sender, EventArgs e)
        {
            generarTablaTarjetas();
            tabla.DataSource = null;
            tabla.DataSource = productosRepositorio.ObtenerTarjetas(cartera.CodigoCartera);
            tabla.DataError += Tabla_DataError;

        }

        private void Tabla_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            e.Cancel = true;
        }

        private void ConfigurarTablaTransacciones()
        {
            tabla.Columns.Clear();
            tabla.AutoGenerateColumns = false;
            tabla.DataSource = null;

            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Número Producto", DataPropertyName = "NumeroProducto" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tipo Transacción", DataPropertyName = "TipoTransaccion" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tipo Producto", DataPropertyName = "TipoProducto" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Monto", DataPropertyName = "MontoTransaccion" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha transacción", DataPropertyName = "FechaTransaccion" });
            tabla.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Descripción", DataPropertyName = "Descripcion" });

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfigurarTablaTransacciones();
            tabla.DataSource = null;
            tabla.DataSource = transaccionesRepositorio.ObtenerTransacciones(cartera.CodigoCartera);

        }
    }
}
