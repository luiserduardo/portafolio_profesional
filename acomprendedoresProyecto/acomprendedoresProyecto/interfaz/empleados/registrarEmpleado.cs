using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using acomprendedoresProyecto.clases;
using acomprendedoresProyecto.repositorios;

namespace acomprendedoresProyecto.pantallas.empleados
{
    public partial class registrarEmpleado : UserControl
    {

        UsuarioRepositorio repositorio = new UsuarioRepositorio();
        Usuario usuario = new Usuario();


        //Para validacion
          Validacion validacion = new Validacion();


        public registrarEmpleado()
        {
            InitializeComponent();
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }


        //metodo para agregar
  


            private void agregar()
        {
            try
            {
                // Validar todos los campos primero
                if (!validacion.ValidarFormularioEmpleado(
                    txtNombre.Text,
                    txtApellidos.Text,
                    txtDui.Text,
                    txtTelefono.Text,
                    txtCorreo.Text,
                    txtDireccion.Text,
                    txtMensual.Text,
                    dateFecha.Value,
                    txtClave.Text,
                    comboEstadoFamiliar.Text,
                    comboPuesto.Text,
                    txtDepartamento.Text,
                    txtProfesion.Text
                    ))
                {
                    return;
                }

                //validado crear
                Empleado empleado = new Empleado(
                    txtCodigoUsuario.Text,
                    txtNombre.Text,
                    txtApellidos.Text,
                    txtDui.Text,
                    dateFecha.Value.Date.ToString(),
                    int.Parse(txtEdad.Text),
                    txtCorreo.Text,
                    txtDireccion.Text,
                    double.Parse(txtMensual.Text),
                    txtTelefono.Text,
                    txtClave.Text,
                    "",
                    comboEstadoFamiliar.Text,
                    comboPuesto.Text,
                    txtDepartamento.Text,
                    txtProfesion.Text
                );

                empleado.EstablecerTipoUsuario(comboPuesto.Text);
                // Limpiar campos
                txtCodigoUsuario.Clear();
                txtNombre.Clear();
                txtApellidos.Clear();
                txtDui.Clear();
                txtCorreo.Clear();
                txtMensual.Clear();
                txtTelefono.Clear();
                txtClave.Clear();
                txtDireccion.Clear();
                txtEdad.Clear();
                txtProfesion.Clear();

                repositorio.RegistrarEmpleado(empleado);
                MessageBox.Show("Empleado registrado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
       
        }
        

      
        private void panelCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void colocarCodigo(object sender, EventArgs e)
        {
            //validar que se tiene mas de 2 caracteres
            if ((txtApellidos.Text).Length > 2)
            {

                //Para generar el codigo del usuario hacer uso de metodo de generarCodigo
                string codigo = usuario.GenerarCodigoUsuario("EMP", txtNombre.Text.ToUpper(), txtApellidos.Text.ToUpper());
                txtCodigoUsuario.Text = codigo;
            }

                validacion.ValidarApellidos(txtApellidos.Text);

        }

        private void generarEdad(object sender, EventArgs e)
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

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            agregar();
                }

        private void txtNombre_leave(object sender, EventArgs e)
        {
            validacion.ValidarNombre(txtNombre.Text);
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

        private void txtMensual_lave(object sender, EventArgs e)
        {
            validacion.ValidarSalario(txtMensual.Text);
        }

        private void lave(object sender, EventArgs e)
        {
            validacion.ValidarClave(txtClave.Text);
        }

        private void txtTelefono_leave(object sender, EventArgs e)
        {
            validacion.ValidarTelefono(txtTelefono.Text);

        }

        private void validarProfesion(object sender, EventArgs e)
        {
            string texto = txtProfesion.Text.Trim();

            // Validar solo letras
            string patron = @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$";
            if (!Regex.IsMatch(texto, patron))
            {
                MessageBox.Show("La profesión solo debe contener letras", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProfesion.Focus();
                return;
            }

            // Validar mínimo 21 caracteres
            if (texto.Length < 21)
            {
                MessageBox.Show("La profesión debe tener al menos 21 caracteres", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProfesion.Focus();
                return;
            }
        }
    }
}
