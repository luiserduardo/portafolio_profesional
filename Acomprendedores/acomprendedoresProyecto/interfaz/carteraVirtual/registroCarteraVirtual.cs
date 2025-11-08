using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using acomprendedoresProyecto.clases;
using acomprendedoresProyecto.repositorios;

namespace acomprendedoresProyecto.pantallas.empleados
{
    public partial class registroCarteraVirtual : UserControl
    {
        private List<CarteraVirtual> listaCartera = new List<CarteraVirtual>();
        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        CarteraVirtualRepositorio carteraUsuario = new CarteraVirtualRepositorio();

        CarteraVirtual cartera;
        Cliente cliente = null;
        public registroCarteraVirtual()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string codigoBuscar = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(codigoBuscar))
            {
                MessageBox.Show("Ingrese un código para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar cliente
            cliente = usuarioRepositorio.ObtenerClientePorCodigoDUI(codigoBuscar);

            if (cliente == null)
            {
                MessageBox.Show("No se encontró ningún cliente con ese código.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtCartera.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtDUI.Clear();
                txtCodigo2.Clear();

                cartera = null;
                return;
            }

            cartera = carteraUsuario.ObtenerCarteraPorCliente(cliente.CodigoUsuario);

            if (cartera == null)
            {
                CarteraVirtual carteraVirtual = new CarteraVirtual();
                txtCartera.Text = carteraVirtual.GenerarCodigoCartera("CV", cliente.CodigoUsuario);

                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtDUI.Text = cliente.DUI;
                txtCodigo2.Text = cliente.CodigoUsuario;

                MessageBox.Show("Cliente encontrado. Puede proceder a crear la cartera.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtCartera.Text = cartera.CodigoCartera;
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtDUI.Text = cliente.DUI;
            txtCodigo2.Text = cliente.CodigoUsuario;
            txtCodigo.Text = txtBuscar.Text;

            MessageBox.Show("Este cliente ya tiene una cartera virtual registrada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        
         
        private void btnCrear_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {

            if (cliente == null)
            {
                MessageBox.Show("No se ha seleccionado un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
             cartera = carteraUsuario.ObtenerCarteraPorCliente(cliente.CodigoUsuario);

            // Existe
            if (cartera != null)
            {
                
                txtCartera.Text = cartera.CodigoCartera;
                MessageBox.Show("Este cliente ya tiene una cartera virtual.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Limpiar otros campos si hace falta
                txtCodigo2.Text = cliente.CodigoUsuario;
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtDUI.Text = cliente.DUI;
                txtCodigo.Text = cliente.CodigoUsuario;

            }
            else
            {
               carteraUsuario.RegistrarVirtual(cliente, txtCartera.Text, txtCodigo.Text);
                MessageBox.Show("Cartera creada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpiar otros campos si hace falta
                txtCodigo2.Text = cliente.CodigoUsuario;
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtDUI.Text = cliente.DUI;
                txtCodigo.Text = cliente.CodigoUsuario;
            }
        }

         
    }
}
