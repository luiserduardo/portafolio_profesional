using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using acomprendedoresProyecto.conexion;

namespace acomprendedoresProyecto.repositorios
{
    public class ReporteRepositorio
    {

        public DataTable ObtenerTransaccionesPorFecha(string codigoCartera, DateTime fechaInicio, DateTime fechaFin, out string mensaje)
        {
            DataTable dt = new DataTable();
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = ConexionDb.ObtenerConexion())
                {
                    using (SqlCommand cmd = new SqlCommand("ObtenerTransaccionClientePorFecha", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CodigoCartera", codigoCartera);
                        cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        cmd.Parameters.AddWithValue("@FechaFin", fechaFin);

                        SqlParameter mensajeParam = new SqlParameter("@Mensaje", SqlDbType.NVarChar, 200)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(mensajeParam);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }

                        mensaje = mensajeParam.Value?.ToString() ?? "Consulta realizada correctamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al obtener transacciones: " + ex.Message;
            }

            return dt;
        }

    }
}
