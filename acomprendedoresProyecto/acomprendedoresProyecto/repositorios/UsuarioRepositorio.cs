using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using acomprendedoresProyecto.clases;
using acomprendedoresProyecto.conexion;
using acomprendedoresProyecto.pantallas.productoFinanciero.Cuenta;

namespace acomprendedoresProyecto.repositorios
{
    public class UsuarioRepositorio
    {

        //Acordate de meter una validacion para comprobar que no exista ya el usuario, sino rolback


        //Obtener
        public List<Usuario> ObtenerTodos()
        {
            List<Usuario> usuariosLista = new List<Usuario>();


            using (SqlConnection conexionDb = ConexionDb.ObtenerConexion())
            {

                string query = "Select * from Usuario";
                SqlCommand cmd = new SqlCommand(query, conexionDb);
                SqlDataReader lectura = cmd.ExecuteReader();

                while (lectura.Read())
                {

                    Usuario u = new Usuario(
         lectura["CodigoUsuario"].ToString(),
         lectura["Nombre"].ToString(),
         lectura["Apellido"].ToString(),
         lectura["DUI"].ToString(),
         lectura["FechaNacimiento"].ToString(),
         int.Parse(lectura["Edad"].ToString()),
         lectura["CorreoElectronico"].ToString(),
         lectura["DireccionPersonal"].ToString(),
         double.Parse(lectura["SalarioMensual"].ToString()),
         lectura["Telefono"].ToString(),
         lectura["Clave"].ToString(),
         lectura["TipoUsuario"].ToString(),
         lectura["Estado"].ToString());

                    usuariosLista.Add(u);

                };
                return usuariosLista;

            }




        }

        public List<Cliente> ObtenerTodosClientes(string Estado)
        {
            List<Cliente> listaClientes = new List<Cliente>();


            using (SqlConnection conexionDb = ConexionDb.ObtenerConexion())
            {

                string query = "Select * from ObtenerClientes where Estado = @Estado";
                SqlCommand cmd = new SqlCommand(query, conexionDb);
                cmd.Parameters.AddWithValue("@Estado", Estado);
                SqlDataReader lectura = cmd.ExecuteReader();

                while (lectura.Read())
                {


                    Cliente cl = new Cliente(
       lectura["CodigoUsuario"].ToString(),
                    lectura["Nombre"].ToString(),
                    lectura["Apellido"].ToString(),
                    lectura["DUI"].ToString(),
                    lectura["FechaNacimiento"].ToString(),
                    int.Parse(lectura["Edad"].ToString()),
                    lectura["CorreoElectronico"].ToString(),
                    lectura["DireccionPersonal"].ToString(),
                    double.Parse(lectura["SalarioMensual"].ToString()),
                    lectura["Telefono"].ToString(),
                    lectura["Clave"].ToString(),
                    lectura["TipoUsuario"].ToString(),
                    lectura["DireccionTrabajo"].ToString(),
                    lectura["Estado"].ToString());

                    cl.AsignarFechaCreacion(Convert.ToDateTime(lectura["FechaCreacion"]));

                    listaClientes.Add(cl);

                };
                return listaClientes;

            }




        }



        public Cliente ObtenerClientePorCodigo(string codigoUsuario)
        {
            Cliente cl = null;

            using (SqlConnection conexionDb = ConexionDb.ObtenerConexion())
            {

                string query = "SELECT * FROM ObtenerClientes WHERE CodigoUsuario = @CodigoUsuario";
                SqlCommand cmd = new SqlCommand(query, conexionDb);
                cmd.Parameters.AddWithValue("@CodigoUsuario", codigoUsuario);

                try {
                    using (SqlDataReader lectura = cmd.ExecuteReader())
                    {

                        if (lectura.Read())
                        {

                            cl = new Cliente(
           lectura["CodigoUsuario"].ToString(),
           lectura["Nombre"].ToString(),
           lectura["Apellido"].ToString(),
           lectura["DUI"].ToString(),
           lectura["FechaNacimiento"].ToString(),
           int.Parse(lectura["Edad"].ToString()),
           lectura["CorreoElectronico"].ToString(),
           lectura["DireccionPersonal"].ToString(),
           double.Parse(lectura["SalarioMensual"].ToString()),
           lectura["Telefono"].ToString(),
           lectura["Clave"].ToString(),
           lectura["TipoUsuario"].ToString(),
                      lectura["DireccionTrabajo"].ToString(),
                                 lectura["Estado"].ToString()


       );

                            DateTime fechaCreacion = Convert.ToDateTime(lectura["FechaCreacion"]);

                        };

                    }
                }
                catch
                {
                    cl = null;
                }



                return cl;

            }




        }



                public Cliente ObtenerClientePorCodigoDUI(string valor)
        {
            Cliente cl = null;

            using (SqlConnection conexionDb = ConexionDb.ObtenerConexion())
            {

                string query = "            SELECT * FROM ObtenerClientes WHERE Estado = 'Activo'  and (DUI = @DUI or CodigoUsuario =@CodigoUsuario) ;";
                SqlCommand cmd = new SqlCommand(query, conexionDb);
                cmd.Parameters.AddWithValue("@CodigoUsuario", valor);
                cmd.Parameters.AddWithValue("@DUI", valor);

                try {
                    using (SqlDataReader lectura = cmd.ExecuteReader())
                    {

                        if (lectura.Read())
                        {

                            cl = new Cliente(
           lectura["CodigoUsuario"].ToString(),
           lectura["Nombre"].ToString(),
           lectura["Apellido"].ToString(),
           lectura["DUI"].ToString(),
           lectura["FechaNacimiento"].ToString(),
           int.Parse(lectura["Edad"].ToString()),
           lectura["CorreoElectronico"].ToString(),
           lectura["DireccionPersonal"].ToString(),
           double.Parse(lectura["SalarioMensual"].ToString()),
           lectura["Telefono"].ToString(),
           lectura["Clave"].ToString(),
           lectura["TipoUsuario"].ToString(),
           lectura["Estado"].ToString(),
                      lectura["DireccionTrabajo"].ToString()

       );

                            DateTime fechaCreacion = Convert.ToDateTime(lectura["FechaCreacion"]);

                        };

                    }
                }
                catch
                {
                    cl = null;
                }



                return cl;

            }




        }


        public List<Empleado> ObtenerTodosEmpleados(string estado)
        {
            List<Empleado> listaEmpleados = new List<Empleado>();


            using (SqlConnection conexionDb = ConexionDb.ObtenerConexion())
            {

                string query = "Select * from ObtenerEmpleados where Estado = @Estado";
                SqlCommand cmd = new SqlCommand(query, conexionDb);
                cmd.Parameters.AddWithValue("@Estado", estado);
                SqlDataReader lectura = cmd.ExecuteReader();

                while (lectura.Read())
                {

                    Empleado emp = new Empleado(
        lectura["CodigoUsuario"].ToString(),
        lectura["Nombre"].ToString(),
        lectura["Apellido"].ToString(),
        lectura["DUI"].ToString(),
        lectura["FechaNacimiento"].ToString(),
        int.Parse(lectura["Edad"].ToString()),
        lectura["CorreoElectronico"].ToString(),
        lectura["DireccionPersonal"].ToString(),
        double.Parse(lectura["SalarioMensual"].ToString()),
        lectura["Telefono"].ToString(),
        lectura["Clave"].ToString(),
        lectura["TipoUsuario"].ToString(),
        lectura["EstadoFamiliar"].ToString(),
        lectura["Puesto"].ToString(),
        lectura["Departamento"].ToString(),
        lectura["Profesion"].ToString()
    );

                    emp.AsignarFechaCreacion(Convert.ToDateTime(lectura["FechaCreacion"]));


                    listaEmpleados.Add(emp);



                };
                return listaEmpleados;

            }




        }


        public Empleado ObtenerEmpleadoPorCodigo(string codigoUsuario)
        {
            Empleado cl = null;

            using (SqlConnection conexionDb = ConexionDb.ObtenerConexion())
            {

                string query = "SELECT * FROM ObtenerEmpleados WHERE CodigoUsuario = @CodigoUsuario and Estado = 'Activo' ";
                SqlCommand cmd = new SqlCommand(query, conexionDb);
                cmd.Parameters.AddWithValue("@CodigoUsuario", codigoUsuario);

                try
                {
                    using (SqlDataReader lectura = cmd.ExecuteReader())
                    {

                        if (lectura.Read())
                        {

                            cl = new Empleado(
           lectura["CodigoUsuario"].ToString(),
           lectura["Nombre"].ToString(),
           lectura["Apellido"].ToString(),
           lectura["DUI"].ToString(),
           lectura["FechaNacimiento"].ToString(),
           int.Parse(lectura["Edad"].ToString()),
           lectura["CorreoElectronico"].ToString(),
           lectura["DireccionPersonal"].ToString(),
           double.Parse(lectura["SalarioMensual"].ToString()),
           lectura["Telefono"].ToString(),
           lectura["Clave"].ToString(),
           lectura["TipoUsuario"].ToString(),
                      lectura["EstadoFamiliar"].ToString(),
                      lectura["Puesto"].ToString(),
                      lectura["Departamento"].ToString(),
                      lectura["Profesion"].ToString(),
                                 lectura["Estado"].ToString()
       );

                            DateTime fechaCreacion = Convert.ToDateTime(lectura["FechaCreacion"]);
                            string fechaContratacion = lectura["FechaContratacion"].ToString();


                        };

                    }
                }
                catch
                {
                    cl = null;
                }


                return cl;

            }




        }



        public Usuario ObtenerUsuarioPorCodigo(string codigoUsuario)
        {
            Usuario usuario = null;

            using (SqlConnection conexionDb = ConexionDb.ObtenerConexion())
            {
                string query = "SELECT * FROM Usuario WHERE CodigoUsuario = @CodigoUsuario";
                SqlCommand cmd = new SqlCommand(query, conexionDb);
                cmd.Parameters.AddWithValue("@CodigoUsuario", codigoUsuario);

                try
                {
                    using (SqlDataReader lectura = cmd.ExecuteReader())
                    {
                        if (lectura.Read())
                        {
                            usuario = new Usuario(
                                lectura["CodigoUsuario"].ToString(),
                                lectura["Nombre"].ToString(),
                                lectura["Apellido"].ToString(),
                                lectura["DUI"].ToString(),
                                lectura["FechaNacimiento"].ToString(),
                                int.Parse(lectura["Edad"].ToString()),
                                lectura["CorreoElectronico"].ToString(),
                                lectura["DireccionPersonal"].ToString(),
                                double.Parse(lectura["SalarioMensual"].ToString()),
                                lectura["Telefono"].ToString(),
                                lectura["Clave"].ToString(),
                                lectura["TipoUsuario"].ToString(),
                                lectura["Estado"].ToString()
                            );

                            usuario.AsignarFechaCreacion(Convert.ToDateTime(lectura["FechaCreacion"]));
                        }
                    }
                }
                catch
                {
                    usuario = null;
                }
            }

            return usuario;
        }

        
        //Insertar
        public void RegistrarCliente(Cliente cl)
        {
            using (SqlConnection conexion = ConexionDb.ObtenerConexion())
                //hacer uso de procedimineto
            using (SqlCommand cmd = new SqlCommand("sp_RegistrarCliente", conexion))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodigoUsuario", cl.CodigoUsuario);
                cmd.Parameters.AddWithValue("@Nombre", cl.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", cl.Apellido);
                cmd.Parameters.AddWithValue("@DUI", cl.DUI);
                cmd.Parameters.AddWithValue("@FechaNacimiento", cl.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Edad", cl.Edad);
                cmd.Parameters.AddWithValue("@CorreoElectronico", cl.CorreoElectronico);
                cmd.Parameters.AddWithValue("@DireccionPersonal", cl.DireccionPersonal);
                cmd.Parameters.AddWithValue("@SalarioMensual", cl.SalarioMensual);
                cmd.Parameters.AddWithValue("@Telefono", cl.Telefono);
                cmd.Parameters.AddWithValue("@Clave", cl.ObtenerClave());
                cmd.Parameters.AddWithValue("@TipoUsuario", cl.ObtenerTipoUsuario());
                cmd.Parameters.AddWithValue("@DireccionTrabajo", cl.DireccionTrabajo);


                //Parametro de salida, indica de cuanto es la extension
                SqlParameter mensaje = new SqlParameter("@Mensaje", System.Data.SqlDbType.NVarChar, 200);
                //indica que es de salida
                mensaje.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(mensaje);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(mensaje.Value.ToString(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //RegistrarCuenta empleado
        public void RegistrarEmpleado(Empleado emp)
        {
            using (SqlConnection conexion = ConexionDb.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_RegistrarEmpleado", conexion))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CodigoUsuario", emp.CodigoUsuario);
                cmd.Parameters.AddWithValue("@Nombre", emp.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", emp.Apellido);
                cmd.Parameters.AddWithValue("@DUI", emp.DUI);
                cmd.Parameters.AddWithValue("@FechaNacimiento", emp.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Edad", emp.Edad);
                cmd.Parameters.AddWithValue("@CorreoElectronico", emp.CorreoElectronico);
                cmd.Parameters.AddWithValue("@DireccionPersonal", emp.DireccionPersonal);
                cmd.Parameters.AddWithValue("@SalarioMensual", emp.SalarioMensual);
                cmd.Parameters.AddWithValue("@Telefono", emp.Telefono);
                cmd.Parameters.AddWithValue("@Clave", emp.ObtenerClave());
                cmd.Parameters.AddWithValue("@TipoUsuario", emp.ObtenerTipoUsuario());
                cmd.Parameters.AddWithValue("@EstadoFamiliar", emp.EstadoFamiliar);
                cmd.Parameters.AddWithValue("@Puesto", emp.Puesto);
                cmd.Parameters.AddWithValue("@Departamento", emp.Departamento);
                cmd.Parameters.AddWithValue("@Profesion", emp.Profesion ?? (object)DBNull.Value);

                //Parametro de salida
                SqlParameter mensaje = new SqlParameter("@Mensaje", System.Data.SqlDbType.NVarChar, 200);
                //indica que es de salid
                mensaje.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(mensaje);

                try
                {
                    //ejecuta y retorna afectadas
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(mensaje.Value.ToString(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        //Actualizar
        public void ActualizarCliente(
      string codigoUsuario,
      string nombre,
      string apellido,
      string dui,
      string fechaNacimiento,
      string edad,
      string correo,
      string direccionPersonal,
      string direccionTrabajo,
      string salarioMensual,
      string telefono,
      string estado)
        {
            using (SqlConnection conexion = ConexionDb.ObtenerConexion())
            using (SqlTransaction transaccion = conexion.BeginTransaction())
            {
                try
                {
                    // 1️ Actualizar  Usuario
                    string queryUsuario = @"UPDATE Usuario 
                                    SET Nombre = @Nombre,
                                        Apellido = @Apellido,
                                        DUI = @DUI,
                                        FechaNacimiento = @FechaNacimiento,
                                        Edad = @Edad,
                                        CorreoElectronico = @CorreoElectronico,
                                        DireccionPersonal = @DireccionPersonal,
                                        SalarioMensual = @SalarioMensual,
                                        Telefono = @Telefono,
                                        Estado = @Estado
                                    WHERE CodigoUsuario = @CodigoUsuario";

                    using (SqlCommand cmdUsuario = new SqlCommand(queryUsuario, conexion, transaccion))
                    {
                        cmdUsuario.Parameters.AddWithValue("@Nombre", nombre);
                        cmdUsuario.Parameters.AddWithValue("@Apellido", apellido);
                        cmdUsuario.Parameters.AddWithValue("@DUI", dui);

                        if (DateTime.TryParse(fechaNacimiento, out DateTime fecha))
                            cmdUsuario.Parameters.AddWithValue("@FechaNacimiento", fecha);
                        else
                            throw new Exception("Formato de fecha inválido");

                        cmdUsuario.Parameters.AddWithValue("@Edad", int.Parse(edad));
                        cmdUsuario.Parameters.AddWithValue("@CorreoElectronico", correo);
                        cmdUsuario.Parameters.AddWithValue("@DireccionPersonal", direccionPersonal);
                        cmdUsuario.Parameters.AddWithValue("@SalarioMensual", double.Parse(salarioMensual));
                        cmdUsuario.Parameters.AddWithValue("@Telefono", telefono);
                        cmdUsuario.Parameters.AddWithValue("@Estado", estado);
                        cmdUsuario.Parameters.AddWithValue("@CodigoUsuario", codigoUsuario);

                        cmdUsuario.ExecuteNonQuery();
                    }

                    // 2️ Actualizar  Cliente
                    string queryCliente = @"UPDATE Cliente 
                                    SET DireccionTrabajo = @DireccionTrabajo
                                    WHERE CodigoUsuario = @CodigoUsuario";

                    using (SqlCommand cmdCliente = new SqlCommand(queryCliente, conexion, transaccion))
                    {
                        cmdCliente.Parameters.AddWithValue("@DireccionTrabajo", direccionTrabajo);
                        cmdCliente.Parameters.AddWithValue("@CodigoUsuario", codigoUsuario);
                        cmdCliente.ExecuteNonQuery();
                    }

                    transaccion.Commit();
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    throw new Exception("Error al actualizar el cliente: " + ex.Message);
                }
            }
        }



        public void ActualizarEmpleado(Empleado emp, string codigoUsuario,
            string Nombre, string Apellido, string Dui, string Fecha, string Edad, string Correo,
            string DireccionPersonal, string SalarioMensual, string Telefono,string EstadoFamiliar, string Puesto, string Deparamento, string profesion, string estado)
        {
            using (SqlConnection conexion = ConexionDb.ObtenerConexion())
            {

                // Iniciamos una transacción
                SqlTransaction transaccion = conexion.BeginTransaction();

                try
                {
                    //1
                    string queryUsuario = @"UPDATE Usuario 
                    SET Nombre = @Nombre,
                        Apellido = @Apellido,
                        DUI = @DUI,
                        FechaNacimiento = @FechaNacimiento,
                        Edad = @Edad,
                        CorreoElectronico = @CorreoElectronico,
                        DireccionPersonal = @DireccionPersonal,
                        SalarioMensual = @SalarioMensual,
                        Telefono = @Telefono,
                        Estado = @Estado
                    WHERE CodigoUsuario = @CodigoUsuario";

                    SqlCommand cmdUsuario = new SqlCommand(queryUsuario, conexion, transaccion);
                    cmdUsuario.Parameters.AddWithValue("@Nombre", Nombre);
                    cmdUsuario.Parameters.AddWithValue("@Apellido", Apellido);
                    cmdUsuario.Parameters.AddWithValue("@DUI", Dui);
                    cmdUsuario.Parameters.AddWithValue("@FechaNacimiento", Convert.ToDateTime(Fecha));
                    cmdUsuario.Parameters.AddWithValue("@Edad", int.Parse(Edad));
                    cmdUsuario.Parameters.AddWithValue("@CorreoElectronico", Correo);
                    cmdUsuario.Parameters.AddWithValue("@DireccionPersonal", DireccionPersonal);
                    cmdUsuario.Parameters.AddWithValue("@SalarioMensual", double.Parse(SalarioMensual));
                    cmdUsuario.Parameters.AddWithValue("@Telefono", Telefono);

                    cmdUsuario.Parameters.AddWithValue("@Estado", estado);

                    cmdUsuario.Parameters.AddWithValue("@CodigoUsuario", emp.CodigoUsuario);
                    cmdUsuario.ExecuteNonQuery();

                    //2
                    // UPDATE Empleado
                    string queryEmpleado = @"UPDATE Empleado 
    SET EstadoFamiliar = @EstadoFamiliar,
        Puesto = @Puesto,
        Departamento = @Departamento,
        Profesion = @Profesion
    WHERE CodigoUsuario = @CodigoUsuario";

                    SqlCommand cmdEmpleado = new SqlCommand(queryEmpleado, conexion, transaccion);
                    cmdEmpleado.Parameters.AddWithValue("@EstadoFamiliar", EstadoFamiliar);
                    cmdEmpleado.Parameters.AddWithValue("@Puesto", Puesto);
                    cmdEmpleado.Parameters.AddWithValue("@Departamento", Deparamento);
                    cmdEmpleado.Parameters.AddWithValue("@Profesion", profesion);
                    cmdEmpleado.Parameters.AddWithValue("@CodigoUsuario", codigoUsuario);

                    cmdEmpleado.ExecuteNonQuery();



                    transaccion.Commit();
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    throw new Exception("Error al actualizar el cliente: " + ex.Message);
                }
            }


        }
    
       //Eliminar

        public void DesactivarUsuario(string codigoUsuario)
        {
            using (SqlConnection conexion = ConexionDb.ObtenerConexion())
            {

                //cambiamos el estado para poder ver el registro de las transacciones

                string query = "UPDATE Usuario set Estado = 'Desactivado' WHERE CodigoUsuario=@CodigoUsuario";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@CodigoUsuario", codigoUsuario);
                cmd.ExecuteNonQuery();
            }
        }


        //Contar clientes
        // Contar todos los clientes
        public int ContarClientes()
        {
            int cuenta = 0;

            using (SqlConnection conexion = ConexionDb.ObtenerConexion())
            {
                string query = "SELECT COUNT(*) FROM Cliente";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cuenta = (int)cmd.ExecuteScalar();
            }

            return cuenta;
        }

        // Contar todos los productos financieros
        public int ContarProductosFinancieros()
        {
            int cuenta = 0;

            using (SqlConnection conexion = ConexionDb.ObtenerConexion())
            {
                string query = "SELECT COUNT(*) FROM ProductoFinancieros";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cuenta = (int)cmd.ExecuteScalar();
            }

            return cuenta;
        }

        // Contar transacciones de la semana actual
        public int ContarTransaccionesSemana()
        {
            int cuenta = 0;

            using (SqlConnection conexion = ConexionDb.ObtenerConexion())
            {
                string query = @"
            SELECT COUNT(*)
            FROM Transaccion
            WHERE FechaTransaccion >= DATEADD(day, 1 - DATEPART(dw, GETDATE()), CAST(GETDATE() AS date))
              AND FechaTransaccion < DATEADD(day, 8 - DATEPART(dw, GETDATE()), CAST(GETDATE() AS date))
        ";

                SqlCommand cmd = new SqlCommand(query, conexion);
                cuenta = (int)cmd.ExecuteScalar();
            }

            return cuenta;
        }

        //Directorio Clientes
        public List<object> ObtenerDirectorioClientes(string estado)
        {
            var listaClientes = new List<object>();

            using (SqlConnection conexionDb = ConexionDb.ObtenerConexion())
            {
                string query = "SELECT * FROM DirectorioClientes WHERE Estado = @Estado";
                SqlCommand cmd = new SqlCommand(query, conexionDb);
                cmd.Parameters.AddWithValue("@Estado", estado); 

                SqlDataReader lectura = cmd.ExecuteReader();

                while (lectura.Read())
                {
                    var cliente = new
                    {
                        CodigoUsuario = lectura["CodigoUsuario"],
                        CodigoCartera = lectura["CodigoCartera"],
                        Nombre = lectura["Nombre"],
                        Apellido = lectura["Apellido"],
                        DUI = lectura["DUI"],
                        CantidadCuentas = lectura["CantidadCuentas"] != DBNull.Value ? lectura["CantidadCuentas"] : 0,
                        CantidadPrestamos = lectura["CantidadPrestamos"] != DBNull.Value ? lectura["CantidadPrestamos"] : 0,
                        CantidadTarjetas = lectura["CantidadTarjetas"] != DBNull.Value ? lectura["CantidadTarjetas"] : 0,
                        Estado = lectura["Estado"]
                    };

                    listaClientes.Add(cliente);
                }
            }

            return listaClientes;
        }







    }
}
