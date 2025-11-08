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
using acomprendedoresProyecto.pantallas.clientesYproductos.seleccionCliente;
using acomprendedoresProyecto.repositorios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace acomprendedoresProyecto.pantallas.clientesYproductos
{
    public partial class clientYProduct : UserControl
    {
        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        public clientYProduct()
        {
            InitializeComponent();
            lblClientesValor.Text = usuarioRepositorio.ContarClientes().ToString();
            lblProductosValor.Text = usuarioRepositorio.ContarProductosFinancieros().ToString();

            cmbEstados.SelectedItem = "Activo";
            tablaUsuarios.DataSource = usuarioRepositorio.ObtenerDirectorioClientes(cmbEstados.Text);

        }


        private void cambiarTabla(object sender, EventArgs e)
        {
            tablaUsuarios.DataSource = usuarioRepositorio.ObtenerDirectorioClientes(cmbEstados.Text);

        }

        private void tablaUsuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (tablaUsuarios.CurrentRow != null)
            {
                Object seleccionado = (Object)tablaUsuarios.CurrentRow.DataBoundItem;
                Detalle detalle = new Detalle(seleccionado);
                detalle.ShowDialog();
            }

        }
    }
}
