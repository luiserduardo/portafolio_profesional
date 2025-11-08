using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using acomprendedoresProyecto.clases;
using acomprendedoresProyecto.conexion;

namespace acomprendedoresProyecto.repositorios
{
    public class CarteraVirtualRepositorio
    {

        //validacion de si existen mas registros en caso contrario no permitir 
        public CarteraVirtual ObtenerCarteraPorCliente(string codigoCliente)
        {
            try
            {
                using (SqlConnection conexion = ConexionDb.ObtenerConexion())
                {
                    // Eliminar estas líneas porque ObtenerConexion() ya abre la conexión
                    // if (conexion.State != ConnectionState.Open)
                    //     conexion.Open();

                    string query = @"
                SELECT TOP 1 CodigoCartera, CodigoCliente, Estado 
                FROM CarteraVirtual 
                WHERE LTRIM(RTRIM(CodigoCliente)) = LTRIM(RTRIM(@CodigoCliente))";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@CodigoCliente", codigoCliente);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new CarteraVirtual
                                {
                                    CodigoCartera = reader["CodigoCartera"].ToString(),
                                    CodigoCliente = reader["CodigoCliente"].ToString(),
                                    Estado = reader["Estado"].ToString()
                                };
                            }
                            else
                            {
                                MessageBox.Show($"No se encontró cartera para el cliente [{codigoCliente}].",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return null;
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al consultar la base de datos: " + ex.Message,
                    "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public void RegistrarVirtual(Cliente cliente, string codigoCartera, string codigoCliente)
        {
            using (SqlConnection conexion = ConexionDb.ObtenerConexion())
            using (SqlTransaction transaccion = conexion.BeginTransaction())
            {
                string query = @"insert into CarteraVirtual  (CodigoCartera, CodigoCliente, Estado) values(@CodigoCartera, @CodigoCliente, 'Activo')";

                SqlCommand cmd = new SqlCommand(query, conexion, transaccion );
                cmd.Parameters.AddWithValue("@CodigoCartera", codigoCartera);
                cmd.Parameters.AddWithValue("@CodigoCliente", codigoCliente);



                cmd.ExecuteNonQuery();

                //Validar en caso de exitos
                transaccion.Commit();
            }
        }
    }

}
