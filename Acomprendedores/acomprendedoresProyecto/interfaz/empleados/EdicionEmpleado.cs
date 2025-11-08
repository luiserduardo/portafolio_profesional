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
    public partial class EdicionUsuarios : Form
    {
        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        Empleado empleado = null;
        Validacion validacion = new Validacion();


        public EdicionUsuarios( string codigoUsuario)
        {
            InitializeComponent();

            MessageBox.Show(codigoUsuario);

            txtCodigos.Text = codigoUsuario;



            empleado = usuarioRepositorio.ObtenerEmpleadoPorCodigo(codigoUsuario);


            txtNombres.Text = empleado.Nombre;
            txtApellido.Text = empleado.Apellido;
            txtDu.Text = empleado.DUI;
            txtFechas.Text = DateTime.Parse(empleado.FechaNacimiento).ToShortDateString();
            txtEda.Text = empleado.Edad.ToString();
            txtCorreos.Text = empleado.CorreoElectronico;
            txtDireccio.Text = empleado.DireccionPersonal;
            comboEstadoFamiliar.Text = empleado.EstadoFamiliar?.Trim();
            txtsSalarioMensual.Text = empleado.SalarioMensual.ToString();
            txtTelefo.Text = empleado.Telefono;
            txtDepartamento.Text = empleado.Departamento;
            comboPuesto.Text = empleado.Puesto?.Trim();
            txtProfesion.Text = empleado.Profesion;
            estado.Text = empleado.Estado;  


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        

        private void modificacion(Empleado empleado, string codigoUsuario,
              string Nombre, string Apellido, string Dui, string Fecha, string Edad, string Correo,
              string DireccionPersonal, string SalarioMensual, string Telefono, string EstadoFamiliar, 
              string Puesto, string Departamento, string profesion,string estado)
        {

            try
            {

                usuarioRepositorio.ActualizarEmpleado(empleado, codigoUsuario, Nombre, Apellido,Dui,
                    Fecha, Edad, Correo, DireccionPersonal, SalarioMensual, Telefono, EstadoFamiliar, Puesto, Departamento, profesion, estado );

                MessageBox.Show("Modificación exitosa");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            //aqui va a ser lo de repo
            modificacion(empleado,
                txtCodigos.Text,
txtNombres.Text,
txtApellido.Text,
txtDu.Text,
txtFechas.Value.Date.ToString()
, txtEda.Text
, txtCorreos.Text
, txtDireccio.Text,
txtsSalarioMensual.Text,
txtTelefo.Text,
comboEstadoFamiliar.Text,
comboPuesto.Text,
txtDepartamento.Text,
txtProfesion.Text,
estado.Text
);




        }

        private void calcularEdad(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            DateTime fechaNacimiento = txtFechas.Value;
            txtEda.Text = usuario.CalcularFecha(fechaNacimiento).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombres_Leave(object sender, EventArgs e)
        {
            validacion.ValidarNombre(txtNombres.Text);


        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            validacion.ValidarApellidos(txtsSalarioMensual.Text);


        }

        private void txtDu_Leave(object sender, EventArgs e)
        {
            validacion.ValidarDui(txtDu.Text);


        }

        private void txtCorreos_Leave(object sender, EventArgs e)
        {
            validacion.ValidarCorreo(txtCorreos.Text);

        }

        private void txtDireccio_Leave(object sender, EventArgs e)
        {
            validacion.ValidarDireccion(txtDireccio.Text);

        }

        private void txtsSalarioMensual_Leave(object sender, EventArgs e)
        {

            validacion.ValidarSalario(txtsSalarioMensual.Text);

        }

        private void txtTelefo_Leave(object sender, EventArgs e)
        {
            validacion.ValidarTelefono(txtTelefo.Text);

        }

        private void txtProfesion_Leave(object sender, EventArgs e)
        {

        }
    }
}
