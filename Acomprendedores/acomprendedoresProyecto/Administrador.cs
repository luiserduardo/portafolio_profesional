using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using acomprendedoresProyecto.pantallas.clientesYproductos;
using acomprendedoresProyecto.pantallas.clientesYproductos.seleccionCliente;
using acomprendedoresProyecto.pantallas.empleados;
using acomprendedoresProyecto.pantallas.productoFinanciero.Cuenta;
using acomprendedoresProyecto.pantallas.productoFinanciero.Prestamo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace acomprendedoresProyecto
{
    public partial class formulario2 : Form
    {
        public formulario2()
        {
            InitializeComponent();

        
        }

        private void cambioMenu(object sender, EventArgs e)
        {
            panelDelContenido.Controls.Clear();
            comboBox1.Visible = false;
            comboBox2.Visible = false;

            switch (menu.Text)
            {
                case "Registrar empleados":
                    panelDelContenido.Controls.Add(new registrarEmpleado());
                    break;

                case "Registrar clientes":
                    panelDelContenido.Controls.Add(new registrarClientes());
                    break;

                case "Ver empleados":
                case "Ver clientes":
                    panelDelContenido.Controls.Add(new verUsuarios(menu.Text));
                    break;

                case "Registrar cartera virtual":
                    panelDelContenido.Controls.Add(new registroCarteraVirtual());
                    break;

                case "Registrar producto financiero":
                    comboBox1.Visible = true;

                  

                    break;

                case "Gestionar productos-clientes":
                    panelDelContenido.Controls.Add(new clientYProduct());
                    break;

                default:
                    MessageBox.Show("Seleccione una opción válida del menú.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }



        }

        private void cambioMenu2(object sender, EventArgs e)
        {
            panelDelContenido.Controls.Clear();

            switch (comboBox1.Text)
            {
                case "Cuenta":

                    panelDelContenido.Controls.Add(new RegistrarCuenta());


                    break;

                case "Prestamo":

                    panelDelContenido.Controls.Add(new RegistrarPrestamo());
                    break;
                default:
                    break;

            }
        }

        private void menu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
