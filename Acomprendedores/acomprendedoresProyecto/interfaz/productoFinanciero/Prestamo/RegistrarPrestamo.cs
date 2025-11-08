using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Hosting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using acomprendedoresProyecto.clases;
using acomprendedoresProyecto.pantallas.productoFinanciero.Prestamo.DatosEspecificos.Agropecurios;
using acomprendedoresProyecto.pantallas.productoFinanciero.Prestamo.DatosEspecificos.Hipotecario;
using acomprendedoresProyecto.pantallas.productoFinanciero.Prestamo.DatosEspecificos.Personal;
using acomprendedoresProyecto.pantallas.productoFinanciero.Prestamo.PantallaDatosGenerales;
using acomprendedoresProyecto.repositorios;

namespace acomprendedoresProyecto.pantallas.productoFinanciero.Prestamo
{
    public partial class RegistrarPrestamo : UserControl
    {


        //Lista de userControl en orden
        private List<UserControl> lista = new List<UserControl>();
        private int panelActual = 0;
        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        Cliente cliente;
        CarteraVirtual cartera;
        CarteraVirtualRepositorio carteraUsuario = new CarteraVirtualRepositorio();
        ProductosRepositorio prestamoRepo = new ProductosRepositorio();

        public RegistrarPrestamo()
        {
            InitializeComponent();

            //instancia panales
            lista = new List<UserControl> {
            new DatosGenerales1(),
                new DatosGenerales2(),
                new DatosGenerales3()
            };

           //Para cada panel en la lista
            foreach (var p in lista)
            {
                p.Visible = false;
                panel3.Controls.Add(p);
            }

            MostrarPanel(panelActual);


        }


        private void MostrarPanel(int indice)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                lista[i].Visible = (i == indice);
            }

            //Activar o desactivar
            button3.Enabled = (indice > 0); 
            button4.Enabled = (indice < lista.Count - 1); 
        }
        private void button1_Click(object sender, EventArgs e)
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
                txtNombre.Clear();
                txtApellido.Clear();
                txtDui.Clear();
                txtCodigoUsuario.Clear();
                txtCorreo.Clear();
                txtCodigoUsuario.Clear();

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
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtCodigoUsuario.Text = cliente.CodigoUsuario;
            txtCorreo.Text = cliente.CorreoElectronico;
            txtDui.Text = cliente.DUI;
            txtCodigoUsuario.Text = cliente.CodigoUsuario;

        }

        private void seleccionTipoPrestamo(object sender, EventArgs e)
        {

            int anio = DateTime.Now.Year;

            Random rnd = new Random();
            int numero = rnd.Next(1, 99999);
            string numeroFormateado = numero.ToString("D5");
            string codigoPrestamo;

            DatosGenerales1 dg1 = lista[0] as DatosGenerales1;

            switch (comboTipoPrestamo.Text)
            {

                case "Hipotecario":


                    panel2.Controls.Clear();

                    panel2.Controls.Add(new DatosHipotecario());

                    codigoPrestamo = $"PRES-{numeroFormateado}-{anio}-HIP";

                    //si esta en posicion 0 que corresponde al ponel donde se muestra el codigo
                    if (dg1 != null)
                    {
                        dg1.CargarDatosGenerales(codigoPrestamo);
                    }


                    break;

                case "Agropecuario":
                    panel2.Controls.Clear();

                    panel2.Controls.Add(new DatosAgropecuario());

                    codigoPrestamo = $"PRES-{numeroFormateado}-{anio}-AGR";

                    if (dg1 != null)
                    {
                        dg1.CargarDatosGenerales(codigoPrestamo);
                    }


                    break;

                case "Personal":
                    panel2.Controls.Clear();

                    codigoPrestamo = $"PRES-{numeroFormateado}-{anio}-PP";

                    //si esta en posicion 0 que corresponde al ponel donde se muestra el codigo
                    if (dg1 != null)
                    {
                        dg1.CargarDatosGenerales(codigoPrestamo);
                    }

                    panel2.Controls.Add(new DatosPersonal());
                    break;


            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panelActual > 0)
            {
                panelActual--;
                MostrarPanel(panelActual);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (panelActual < lista.Count - 1)
            {
                panelActual++;
                MostrarPanel(panelActual);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cartera == null)
            {
                MessageBox.Show("No se ha seleccionado un cliente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DatosGenerales1 dg1 = lista[0] as DatosGenerales1;
            if (dg1 == null)
            {
                MessageBox.Show("No se pudo obtener los datos generales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DatosGenerales2 dg2 = lista[1] as DatosGenerales2;
            if (dg2 == null)
            {
                MessageBox.Show("No se pudo obtener los datos generales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            DatosGenerales3 dg3 = lista[2] as DatosGenerales3;
            if (dg3 == null)
            {
                MessageBox.Show("No se pudo obtener los datos generales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string numeroProducto = dg1.txtCodigoPrestamo.Text;
            string tipoPrestamo = comboTipoPrestamo.Text;
            string codigoCartera = txtCodigoCartera.Text.Trim();

            //  generales
            double montoOtorgado = double.Parse(dg1.txtMonto.Text);
            int plazoMeses = int.Parse(dg2.txtPlazo.Text);
            double cuota = double.Parse(dg2.txtCuota.Text);
            DateTime fechaLimitePago = dg2.dateTimePicker1.Value;
            double tasaInteres = double.Parse(dg3.txtTasaInteres.Text);
            double cuotaSeguro = double.Parse(dg3.txtSeguro.Text);

            // espec
            string tipoActividad = null, descripcionActividad = null;
            string tipoPropiedad = null, direccionPropiedad = null;
            double valorPropiedad = 0;
            string numeroReferencia = null;

            
            switch (tipoPrestamo)
            {
                case "Agropecuario":
                    if (panel2.Controls[0] is DatosAgropecuario da)
                    {
                        tipoActividad = da.txtTipoActividad.Text;
                        descripcionActividad = da.txtTipoActividad.Text;
                    }
                    break;

                case "Hipotecario":
                    if (panel2.Controls[0] is DatosHipotecario dh)
                    {
                        tipoPropiedad = dh.txtTipoPropiedad.Text;
                        direccionPropiedad = dh.txtDireccionTrabajo.Text;
                        valorPropiedad = double.TryParse(dh.txtValorPropiedad.Text, out var vp) ? vp : 0;
                    }
                    break;

                case "Personal":
                    if (panel2.Controls[0] is DatosPersonal dp)
                    {
                        numeroReferencia = dp.txtNumeroReferencia.Text;
                    }
                    break;
            }

            bool exito = prestamoRepo.CrearProductoFinancieroPrestamo(
                numeroProducto,
                tipoPrestamo,
                codigoCartera,
                montoOtorgado,
                plazoMeses,
                cuota,
                fechaLimitePago,
                tasaInteres,
                cuotaSeguro,
                tipoActividad,
                descripcionActividad,
                tipoPropiedad,
                direccionPropiedad,
                valorPropiedad,
                numeroReferencia
            );

            if (exito)
            {
                MessageBox.Show("Préstamo creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarTodo();
            }
            else
            {
                MessageBox.Show("Error al crear el préstamo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void LimpiarTodo()
        {
            LimpiarControles(this);

            LimpiarControles(panel2);
            panel2.Controls.Clear();

            LimpiarControles(panel3);

            cliente = null;
            cartera = null;
            panelActual = 0;

            MostrarPanel(panelActual);
        }

        private void LimpiarControles(Control contenedor)
        {
            foreach (Control ctrl in contenedor.Controls)
            {
                switch (ctrl)
                {
                    case TextBox txt:
                        txt.Clear();
                        break;
                    case ComboBox cmb:
                        cmb.SelectedIndex = -1;
                        break;
                    case DateTimePicker dtp:
                        dtp.Value = DateTime.Now;
                        break;
                    case CheckBox chk:
                        chk.Checked = false;
                        break;
                    case RadioButton rdb:
                        rdb.Checked = false;
                        break;
                    case NumericUpDown num:
                        num.Value = num.Minimum;
                        break;
                    case MaskedTextBox mtxt:
                        mtxt.Clear();
                        break;
                    case RichTextBox rtxt:
                        rtxt.Clear();
                        break;
                    default:
                        if (ctrl.HasChildren)
                        {
                            LimpiarControles(ctrl);
                        }
                        break;
                }
            }
        }
            



        private void RegistrarPrestamo_Load(object sender, EventArgs e)
        {

        }
    }
}
