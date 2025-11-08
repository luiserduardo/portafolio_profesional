using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using acomprendedoresProyecto.pantallas.asesorVentas.consultarCartera;
using acomprendedoresProyecto.pantallas.empleados;
using acomprendedoresProyecto.ui.transaccion;

namespace acomprendedoresProyecto
{
    public partial class PerfilVentas : Form
    {

        string empleado = null;
        public PerfilVentas(string empleado)
        {
            InitializeComponent();
            this.empleado = empleado;
        }

        private void cambioMenu(object sender, EventArgs e)
        {


            if (menu.Text == "Ver cartera")
            {
                panelDelContenido.Controls.Clear();

                panelDelContenido.Controls.Add(new consultarCartera());
            }
            else if (menu.Text == "Registrar deposito")
            {
                panelDelContenido.Controls.Clear();
panelDelContenido.Controls.Add(new deposito(empleado));





            }
        }

        private void panelDelContenido_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
