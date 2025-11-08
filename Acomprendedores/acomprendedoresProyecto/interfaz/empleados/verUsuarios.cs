using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using acomprendedoresProyecto.clases;
using System.IO;
using System.Security;
using acomprendedoresProyecto.repositorios;
using System.Diagnostics.Eventing.Reader;

namespace acomprendedoresProyecto.pantallas.empleados
{
    public partial class verUsuarios : UserControl
    {

        //Declarar dos listas que contienen los datos de empleados y clientes
        private List<Empleado> listaEmpleados = new List<Empleado>();
       private List<Cliente> listaClientes = new List<Cliente>();

        //Acodarte de incluir algo por si falla esto
        UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();

        string tituloOperacion;

        public verUsuarios(string titulo )
        {
            InitializeComponent();
            //generarTabla();

           this.tituloOperacion = titulo;
            tituloTabla(titulo, "Activo");

        }

        //metodo para colocar el titulo en la tabla
        private void tituloTabla(string titulo, string estado)
        {
            if (titulo == "Ver empleados")
            {

                //Modificar titulo
                label2.Text = "Empleados";

                tablaUsuarios.DataSource = usuarioRepositorio.ObtenerTodosEmpleados(estado);

                generarTablaEmpleados();


            }
            else if (titulo == "Ver clientes")
            {
                //Modificar titulo
                label2.Text = "Clientes";


                tablaUsuarios.DataSource = null;
                generarTablaClientes();



                //cargar en tabla
                tablaUsuarios.DataSource = usuarioRepositorio.ObtenerTodosClientes(estado);
            }


        }


        //metodo para generar tabla con orden especifico
      private void generarTablaEmpleados()
        {
           tablaUsuarios.AutoGenerateColumns = false; 
            tablaUsuarios.Columns.Clear();

         tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Código", DataPropertyName = "CodigoUsuario" });
            tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Nombre", DataPropertyName = "Nombre" });
            tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Apellido", DataPropertyName = "Apellido" });
            tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "DUI", DataPropertyName = "DUI" });

          tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha Nacimiento", DataPropertyName = "FechaNacimiento" });
          tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Edad", DataPropertyName = "Edad" });
           tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Correo", DataPropertyName = "CorreoElectronico" });
           tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Dirección Personal", DataPropertyName = "DireccionPersonal" });
           tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Salario mensual", DataPropertyName = "SalarioMensual" });
          tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Telefono", DataPropertyName = "Telefono" });

            tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "FechaCreacion", DataPropertyName = "FechaCreacion" });
            tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Estado", DataPropertyName = "Estado" });
            tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "EstadoFamiliar", DataPropertyName = "EstadoFamiliar" });
            tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Puesto", DataPropertyName = "Puesto" });

            tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Departamento", DataPropertyName = "Departamento" });
            tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Profesion", DataPropertyName = "Profesion" });

        }


        //metodo para generar tabla con orden especifico
        private void generarTablaClientes()
        {
            tablaUsuarios.AutoGenerateColumns = false;
            tablaUsuarios.Columns.Clear();

            tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Código", DataPropertyName = "CodigoUsuario" });
            tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Nombre", DataPropertyName = "Nombre" });
            tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Apellido", DataPropertyName = "Apellido" });
            tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "DUI", DataPropertyName = "DUI" });

            tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha Nacimiento", DataPropertyName = "FechaNacimiento" });
            tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Edad", DataPropertyName = "Edad" });
            tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Correo", DataPropertyName = "CorreoElectronico" });
            tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Dirección Personal", DataPropertyName = "DireccionPersonal" });
            tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Salario mensual", DataPropertyName = "SalarioMensual" });
            tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Telefono", DataPropertyName = "Telefono" });

            tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "FechaCreacion", DataPropertyName = "FechaCreacion" });
            tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Dirección Trabajo", DataPropertyName = "DireccionTrabajo" });

            tablaUsuarios.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Estado", DataPropertyName = "Estado" });


        }

        private void seleccion(object sender, DataGridViewCellMouseEventArgs e)
        {


            //Verifica que no se selecciono el encabezado
            if (e.RowIndex >= 0)
            {
                //Coleccion de todas las filas

                DataGridViewRow fila = tablaUsuarios.Rows[e.RowIndex];

                //abrimos y mandamos los valores

                //abrir formulario y mandar los datos
                string codigoUsuario = fila.Cells[0].Value.ToString();

                string estadoSeleccionado;
                if (comBox.SelectedItem != null)
                {
                    estadoSeleccionado= comBox.SelectedItem.ToString();


                }
                else
                {
                   estadoSeleccionado = "Activo";
                }



                DialogResult accion = MessageBox.Show(
                        "¿Qué deseas hacer con este registro?\n\nSí = Editar\nNo = Eliminar\nCancelar = Salir",
                        "Acción sobre el registro",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Question
                    );

                if (accion == DialogResult.Yes)
                {

                    if (tituloOperacion == "Ver clientes")
                    {
                        EdicionClientes edicionFormulario = new EdicionClientes(codigoUsuario);

                        edicionFormulario.ShowDialog();

                        // Recargar tabla 
                        tablaUsuarios.DataSource = usuarioRepositorio.ObtenerTodosClientes(estadoSeleccionado);
                        generarTablaClientes();
                    }
                    else
                    {

                        EdicionUsuarios edicionFormulario = new EdicionUsuarios(codigoUsuario);

                        edicionFormulario.ShowDialog();

                        //recargar tabla
                        tablaUsuarios.DataSource = usuarioRepositorio.ObtenerTodosEmpleados(estadoSeleccionado);
                        generarTablaEmpleados();
                    }
                }
                else if(accion == DialogResult.No)
    {
                    DialogResult confirmar = MessageBox.Show(
                        "¿Seguro que deseas eliminar este registro?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirmar == DialogResult.Yes)
                    {

                        if (tituloOperacion == "Ver clientes")
                        {
                            usuarioRepositorio.DesactivarUsuario(codigoUsuario);

                        }
                        else if(tituloOperacion=="Ver empleados")
                        {
                            usuarioRepositorio.DesactivarUsuario(codigoUsuario);


                        }

                        MessageBox.Show("Registro eliminado correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);



                            //hacer uso del metodo 

                        }
                    }
    else
                {
                    MessageBox.Show("Operación cancelada.", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        //Evento del combobox, se ejecuta cada que se hace el cambio de valor
        private void cambioValor(object sender, EventArgs e)
        {

            string estadoSeleccionado = comBox.SelectedItem.ToString();

            if (tituloOperacion == "Ver empleados")
            {
                tablaUsuarios.DataSource = usuarioRepositorio.ObtenerTodosEmpleados(estadoSeleccionado);
            }
            else if (tituloOperacion == "Ver clientes")
            {
                tablaUsuarios.DataSource = usuarioRepositorio.ObtenerTodosClientes(estadoSeleccionado);
            }

        }
    


    }
    }

