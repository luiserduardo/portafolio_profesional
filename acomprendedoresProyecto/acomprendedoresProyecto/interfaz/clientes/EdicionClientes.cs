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
using acomprendedoresProyecto.clases;
using acomprendedoresProyecto.repositorios;

namespace acomprendedoresProyecto.pantallas.empleados
{
    public partial class EdicionClientes : Form
    {
        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        Cliente cliente = null;
        Validacion validacion = new Validacion();

        public EdicionClientes( string codigoUsuario)
        {

            InitializeComponent();

            txtCodigo.Text = codigoUsuario;

            //Aqui lo que hacemos es recuperar los datos de la db y colocamos esos datos


            cliente = usuarioRepositorio.ObtenerClientePorCodigo(codigoUsuario);


            txtNombre.Text = cliente.Nombre;
            txtApellidos.Text = cliente.Apellido;
            txtDui.Text = cliente.DUI;
            txtFecha.Text = DateTime.Parse(cliente.FechaNacimiento).ToShortDateString();
            txtEdad.Text = cliente.Edad.ToString();
            txtCorreo.Text = cliente.CorreoElectronico;
            txtDireccion.Text = cliente.DireccionPersonal;
            txtDireccionTrabajo.Text = cliente.DireccionTrabajo;
            txtSalario.Text = cliente.SalarioMensual.ToString();
            txtTelefono.Text = cliente.Telefono;
            txtEstado.Text = cliente.Estado;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                modificacion(
                    txtCodigo.Text,
                    txtNombre.Text,
                    txtApellidos.Text,
                    txtDui.Text,
                    txtFecha.Value.Date.ToString(),
                    txtEdad.Text,
                    txtCorreo.Text,
                    txtDireccion.Text,
                    txtDireccionTrabajo.Text,
                    txtSalario.Text,
                    txtTelefono.Text,
                    txtEstado.Text 
                );

                MessageBox.Show("Cliente actualizado correctamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void modificacion(
            string codigoUsuario,
            string nombre,
            string apellido,
            string dui,
            string fecha,
            string edad,
            string correo,
            string direccionPersonal,
            string direccionTrabajo,
            string salarioMensual,
            string telefono,
            string estado)
        {
            try
            {
                usuarioRepositorio.ActualizarCliente(
                    codigoUsuario,
                    nombre,
                    apellido,
                    dui,
                    fecha,
                    edad,
                    correo,
                    direccionPersonal,
                    direccionTrabajo,
                    salarioMensual,
                    telefono,
                    estado
                );
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar la modificación: " + ex.Message);
            }
        }


        private void calcularEdad(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            DateTime fechaNacimiento = txtFecha.Value;
            txtEdad.Text = usuario.CalcularFecha(fechaNacimiento).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtNombre_leave(object sender, EventArgs e)

        {
            validacion.ValidarNombre(txtNombre.Text);


        }

        private void txtApellidos_leave(object sender, EventArgs e)
        {

            validacion.ValidarApellidos(txtApellidos.Text);

        }

        private void txtDui_leave(object sender, EventArgs e)
        {
            validacion.ValidarDui(txtDui.Text);


        }

        private void txtCorreo_leave(object sender, EventArgs e)
        {
            validacion.ValidarCorreo(txtCorreo.Text);


        }

        private void txtDireccion_lave(object sender, EventArgs e)
        {
            validacion.ValidarDireccion(txtDireccion.Text);

        }

        private void txtDireccion_leave(object sender, EventArgs e)
        {
            validacion.ValidarDireccion(txtDireccionTrabajo.Text);

        }

        private void txtSalario_leave(object sender, EventArgs e)
        {
            validacion.ValidarSalario(txtSalario.Text);


        }

        private void txtTelefono_leave(object sender, EventArgs e)
        {
            validacion.ValidarTelefono(txtTelefono.Text);


        }
    }
}
