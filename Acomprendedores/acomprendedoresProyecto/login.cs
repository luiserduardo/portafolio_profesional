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

namespace acomprendedoresProyecto
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();

       
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                var repo = new LoginRepositorio();
                string tipo = repo.login(textBox1.Text, textBox2.Text);

                //Comprobar si es diferente de nulo
                if (!string.IsNullOrEmpty(tipo))
                {
                    if (tipo == "Administrador")
                    {
                        formulario2 pantallaAdmin = new formulario2();
                        pantallaAdmin.Show();

                    }
                    else if (tipo == "Ventas")
                    {

                        PerfilVentas perfilVentas = new PerfilVentas(textBox1.Text);
                        perfilVentas.Show();

                    }
                    else if (tipo == "Cliente")
                    {
                        PerfilCliente perfilCliente = new PerfilCliente(textBox1.Text);
                        perfilCliente.Show();
                    }
                    else
                    {
                        MessageBox.Show($"Login correcto. Tipo: {tipo}");
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o clave incorrecta.", "Login fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
