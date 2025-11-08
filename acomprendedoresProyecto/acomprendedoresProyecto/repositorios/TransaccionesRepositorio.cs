using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using acomprendedoresProyecto.clases;
using acomprendedoresProyecto.conexion;
using acomprendedoresProyecto.pantallas.productoFinanciero.Cuenta;
using acomprendedoresProyecto.ui.transaccion;

namespace acomprendedoresProyecto.repositorios
{
    public class TransaccionesRepositorio
    {
        // metod para obtener transacciones
        public List<Transaccion> ObtenerTransacciones(string codigoCartera)
        {
            List<Transaccion> transacciones = new List<Transaccion>();

            using (SqlConnection conexion = ConexionDb.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand("ObtenerTransaccionCliente", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CodigoCartera", codigoCartera);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Transaccion transaccion = new Transaccion
                            {
                                NumeroReferencia = reader["NumeroReferencia"].ToString(),
                                TipoProducto = reader["TipoProducto"].ToString(),
                                NumeroProducto = reader["NumeroProducto"].ToString(),
                                TipoTransaccion = reader["TipoTransaccion"].ToString(),
                                MontoTransaccion = reader["MontoTransaccion"] == DBNull.Value ? 0 : Convert.ToDouble(reader["MontoTransaccion"]),
                                FechaTransaccion = Convert.ToDateTime(reader["FechaTransaccion"]),
                                Descripcion = reader["Descripcion"].ToString(),
                                CodigoCartera = codigoCartera
                            };

                            transacciones.Add(transaccion);
                        }
                    }
                }
            }

            return transacciones;
        }

        //Registrar un deposito en la cuenta
        public string RegistrarDeposito(
       string codigoEmpleado,
       string codigoCartera,
       decimal monto,
       string descripcion,
       string numeroProducto,
       int numeroSecuencial) 
        {
            string mensaje = string.Empty;

            string anio = DateTime.Now.Year.ToString();
            string numeroReferencia = $"TRX-{numeroSecuencial:D3}-{codigoCartera}-{anio}";

            using (SqlConnection conexion = ConexionDb.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("registrarTransaccionDeposito", conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Numeroreferencia", numeroReferencia);
                cmd.Parameters.AddWithValue("@CodigoEmpleado", codigoEmpleado);
                cmd.Parameters.AddWithValue("@CodigoCartera", codigoCartera);
                cmd.Parameters.AddWithValue("@MontoTransaccion", monto);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.Parameters.AddWithValue("@NumeroProducto", numeroProducto);
                cmd.Parameters.AddWithValue("@TipoTransaccion", "Depósito"); 

                SqlParameter mensajeParam = new SqlParameter("@Mensaje", SqlDbType.NVarChar, 200)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(mensajeParam);

                cmd.ExecuteNonQuery();

                mensaje = mensajeParam.Value.ToString();
            }

            return mensaje;
        }


        public string RetirarDIneroCuenta(
    string numeroProducto,
    decimal monto,
    string tipoCuenta,
    string descripcion,
    string codigoCartera,
    int numeroSecuencial)
        {
            string mensaje = string.Empty;

            string anio = DateTime.Now.Year.ToString();
            string numeroReferencia = $"TRX-{numeroSecuencial:D3}-{codigoCartera}-{anio}";

            try
            {
                using (SqlConnection conexion = ConexionDb.ObtenerConexion())
                using (SqlCommand cmd = new SqlCommand("RetirarDineroCuenta", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NumeroReferencia", numeroReferencia);
                    cmd.Parameters.AddWithValue("@NumeroProducto", numeroProducto);
                    cmd.Parameters.AddWithValue("@Monto", monto);
                    cmd.Parameters.AddWithValue("@TipoCuenta", tipoCuenta);
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@CodigoCartera", codigoCartera);

                    SqlParameter mensajeParam = new SqlParameter("@Mensaje", System.Data.SqlDbType.NVarChar, 200)
                    {
                        Direction = System.Data.ParameterDirection.Output
                    };
                    cmd.Parameters.Add(mensajeParam);

                    cmd.ExecuteNonQuery();

                    mensaje = mensajeParam.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al retirar dinero: " + ex.Message;
            }

            return mensaje;
        }




        public string RetirarDineroTarjeta(
        string numeroProducto,
        decimal monto,
        string tipoTarjeta,
        string descripcion,
        string codigoCartera,
        int numeroSecuencial,
        string codigoEmpleado = null)
        {
            string mensaje = string.Empty;

            string anio = DateTime.Now.Year.ToString();
            string numeroReferencia = $"TRX-{numeroSecuencial:D3}-{codigoCartera}-{anio}";

            try
            {
                using (SqlConnection conexion = ConexionDb.ObtenerConexion())
                using (SqlCommand cmd = new SqlCommand("RetirarDineroTarjeta", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NumeroReferencia", numeroReferencia);
                    cmd.Parameters.AddWithValue("@NumeroProducto", numeroProducto);
                    cmd.Parameters.AddWithValue("@Monto", monto);
                    cmd.Parameters.AddWithValue("@TipoTarjeta", tipoTarjeta);
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@CodigoCartera", codigoCartera);

                    if (!string.IsNullOrEmpty(codigoEmpleado))
                    {
                        cmd.Parameters.AddWithValue("@CodigoEmpleado", codigoEmpleado);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@CodigoEmpleado", DBNull.Value);
                    }

                    SqlParameter mensajeParam = new SqlParameter("@Mensaje", SqlDbType.NVarChar, 200)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(mensajeParam);

                    cmd.ExecuteNonQuery();

                    mensaje = mensajeParam.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al retirar dinero: " + ex.Message;
            }

            return mensaje;
        }


        //Para pagar el prestamo
        public string PagarPrestamo(
    string numeroProductoPrestamo,
    string numeroProductoCuenta,
    decimal montoPago,
    string tipoCuenta,
    string codigoCartera,
    string descripcion,
    int numeroSecuencial)
        {
            string mensaje = string.Empty;

            string anio = DateTime.Now.Year.ToString();
            string numeroReferencia = $"TRX-{numeroSecuencial:D3}-{codigoCartera}-{anio}";

            try
            {
                using (SqlConnection conexion = ConexionDb.ObtenerConexion())
                using (SqlCommand cmd = new SqlCommand("PagarPrestamo", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NumeroReferencia", numeroReferencia);
                    cmd.Parameters.AddWithValue("@NumeroProductoPrestamo", numeroProductoPrestamo);
                    cmd.Parameters.AddWithValue("@NumeroProductoCuenta", numeroProductoCuenta);
                    cmd.Parameters.AddWithValue("@MontoPago", montoPago);
                    cmd.Parameters.AddWithValue("@TipoCuenta", tipoCuenta);
                    cmd.Parameters.AddWithValue("@CodigoCartera", codigoCartera);
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                    SqlParameter mensajeParam = new SqlParameter("@Mensaje", SqlDbType.NVarChar, 200)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(mensajeParam);

                    cmd.ExecuteNonQuery();

                    mensaje = mensajeParam.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al procesar el pago del préstamo: " + ex.Message;
            }

            return mensaje;
        }


        //Para realizar transferencia
        public string RealizarTransferencia(
    string codigoCarteraOrigen,
    string codigoCarteraDestino,
    string numeroProductoOrigen,
    string numeroProductoDestino,
    decimal montoTransferencia,
    string descripcion,
    int numeroSecuencial,
    string codigoEmpleado = null)
        {
            string mensaje = string.Empty;

            // Generar número de referencia único
            string anio = DateTime.Now.Year.ToString();
            string numeroReferencia = $"TRX-{numeroSecuencial:D3}-{codigoCarteraOrigen}-{anio}";

            try
            {
                using (SqlConnection conexion = ConexionDb.ObtenerConexion())
                using (SqlCommand cmd = new SqlCommand("pc_RealizarTransferencia", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NumeroReferencia", numeroReferencia);
                    cmd.Parameters.AddWithValue("@CodigoCarteraOrigen", codigoCarteraOrigen);
                    cmd.Parameters.AddWithValue("@CodigoCarteraDestino", codigoCarteraDestino);
                    cmd.Parameters.AddWithValue("@NumeroProductoOrigen", numeroProductoOrigen);
                    cmd.Parameters.AddWithValue("@NumeroProductoDestino", numeroProductoDestino);
                    cmd.Parameters.AddWithValue("@MontoTransferencia", montoTransferencia);
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                    if (!string.IsNullOrEmpty(codigoEmpleado))
                    {
                        cmd.Parameters.AddWithValue("@CodigoEmpleado", codigoEmpleado);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@CodigoEmpleado", DBNull.Value);
                    }

                    SqlParameter mensajeParam = new SqlParameter("@Mensaje", SqlDbType.NVarChar, 200)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(mensajeParam);

                    cmd.ExecuteNonQuery();

                    mensaje = mensajeParam.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al procesar la transferencia: " + ex.Message;
            }

            return mensaje;
        }



    



}
}
