using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using acomprendedoresProyecto.clases;
using acomprendedoresProyecto.repositorios;

namespace acomprendedoresProyecto.pantallas.empleados
{
    public partial class registrarClientes : UserControl
    {

        private List<Cliente> listaClientes = new List<Cliente>();
        UsuarioRepositorio repositorio = new UsuarioRepositorio();


        //instanciar objeto
        Usuario usuario = new Usuario();

       Validacion validacion = new Validacion();
        public registrarClientes()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            agregar();
        }


        private void agregar()
        {


            //validar fecha si es demasiado baja o alto

            //metodo para validar datos 
            //todos los datos deben estar

            try
            {

                //instanciar objeto
                Cliente cliente = new Cliente(
         txtCodigoUsuario.Text,
         txtNombre.Text,
         txtApellidos.Text,
         txtDui.Text,
         dateFecha.Value.Date.ToString(),
         int.Parse(txtEdad.Text),
         txtCorreo.Text,
         txtDireccionPersonal.Text,
         double.Parse(txtMensual.Text),
         txtTelefono.Text,
         "",
         "",
         txtDireccion.Text
     );

                //valores protegidos
                cliente.EstablecerClave(txtClave.Text);
                cliente.EstablecerTipoUsuario("Cliente");



                txtCodigoUsuario.Clear();
                txtNombre.Clear();
                txtApellidos.Clear();
                txtDui.Clear();
                txtCorreo.Clear();
                txtDireccionPersonal.Clear();
                txtMensual.Clear();
                txtTelefono.Clear();
                txtClave.Clear();
                txtDireccion.Clear();

                txtEdad.Clear();

                repositorio.RegistrarCliente(cliente);
                MessageBox.Show("Cliente registrado correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void registrarClientes_Load(object sender, EventArgs e)
        {

        }

        //Metodo que se ejecuta cada que cambia Apellidos para generar el codigo

        private void txtApellidos_Leave(object sender, EventArgs e)
        {
            //validar que se tiene mas de 2 caracteres
            if ((txtApellidos.Text).Length > 2)
            {

                //Para generar el codigo del usuario hacer uso de metodo de generarCodigo
                string codigo = usuario.GenerarCodigoUsuario("CT", txtNombre.Text.ToUpper(), txtApellidos.Text.ToUpper());
                txtCodigoUsuario.Text = codigo;
            }

            validacion.ValidarApellidos(txtApellidos.Text);



        }

      

        private void txtNombre_lave(object sender, EventArgs e)
        {
            validacion.ValidarNombre(txtNombre.Text);
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            validacion.ValidarCorreo(txtCorreo.Text);
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {

        }

        private void txtDireccionPersonal_Leave(object sender, EventArgs e)
        {

        }

        private void txtMensual_Leave(object sender, EventArgs e)
        {
            validacion.ValidarSalario(txtMensual.Text);

        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            validacion.ValidarTelefono(txtTelefono.Text);
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            validacion.ValidarClave(txtClave.Text);
        }

        private void txtDui_lave(object sender, EventArgs e)
        {
            validacion.ValidarDui(txtDui.Text);

        }

   
        private void dateFecha_Leave(object sender, EventArgs e)
        {
            DateTime fechaNacimiento = dateFecha.Value;
            int edadCalculada = usuario.CalcularFecha(fechaNacimiento);

            if (!new Validacion().ValidarFechaNacimiento(fechaNacimiento))
            {
                txtEdad.Clear();

                dateFecha.Value = DateTime.Now.AddYears(-18);
                txtEdad.Text = "18";
                return;
            }

            // Si pasa la validación, mostrar la edad
            txtEdad.Text = edadCalculada.ToString();
        }
    }

}
