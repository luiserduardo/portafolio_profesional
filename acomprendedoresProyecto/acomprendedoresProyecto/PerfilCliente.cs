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
using acomprendedoresProyecto.interfaz.transaccion;
using acomprendedoresProyecto.pantallas.asesorVentas.consultarCartera;
using acomprendedoresProyecto.pantallas.clientesYproductos.seleccionCliente;
using acomprendedoresProyecto.repositorios;
using acomprendedoresProyecto.ui.transaccion;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace acomprendedoresProyecto
{
    public partial class PerfilCliente : Form
    {

        string codigoCliente = null;
        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        CarteraVirtual cartera = null;
        Cliente cliente = null;


        public PerfilCliente(string codigoCliente)
        {
            InitializeComponent();

            this.codigoCliente = codigoCliente;
            cliente = usuarioRepositorio.ObtenerClientePorCodigo(this.codigoCliente);


        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menu.Text == "Ver productos financieros")
            {
                Detalle detalle = new Detalle(cliente);
                detalle.ShowDialog();
                
            }else if(menu.Text =="Retirar de cuenta")
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(new retirarCuenta(cliente));
            }else if (menu.Text =="Retirar de tarjeta")
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(new RetiroTarjeta(cliente));
            }
            else if (menu.Text == "Pagar prestamo")
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(new pagarPrestamo(cliente));
            }else if( menu.Text == "Transferir")
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(new transferencia(cliente));
            }




        }
    }

}