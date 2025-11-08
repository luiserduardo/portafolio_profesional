using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using acomprendedoresProyecto.clases;
using acomprendedoresProyecto.conexion;

namespace acomprendedoresProyecto.repositorios
{
    public class ProductosRepositorio
    {
        //metodo para obtener las cuentas
        public List<Cuenta> ObtenerCuentas(string codigoCartera)
        {
            List<Cuenta> cuentas = new List<Cuenta>();

            using (SqlConnection conexion = ConexionDb.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("ObtenerCuentas", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodigoCartera", codigoCartera);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cuenta cuenta = new Cuenta
                        {
                            NumeroProducto = reader["NumeroProducto"].ToString(),
                            CodigoCartera = codigoCartera,
                            TipoProducto = "Cuenta",
                            TipoCuenta = reader["TipoCuenta"].ToString(),
                            FechaAdquisicion = Convert.ToDateTime(reader["FechaAdquisicion"]),
                            FechaCierre = reader["FechaCierre"] == DBNull.Value
                                ? (DateTime?)null
                                : Convert.ToDateTime(reader["FechaCierre"]),
                            Saldo = double.Parse(reader["Saldo"].ToString()),
                            Estado = reader["Estado"].ToString()
                        };

                        cuentas.Add(cuenta);
                    }
                }
            }

            return cuentas;
        }

        //metodo para obtener prestamos
        public List<object> ObtenerPrestamos(string codigoCartera)
        {
            List<object> prestamos = new List<object>();

            using (SqlConnection conexion = ConexionDb.ObtenerConexion())
            {
                //// prestmaos
                string[] tiposPrestamo = { "Personal", "Hipotecario", "Agropecuario" };


                foreach (var tipo in tiposPrestamo)
                {
                    using (SqlCommand cmd = new SqlCommand("ObtenerPrestamo", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CodigoCartera", codigoCartera);
                        cmd.Parameters.AddWithValue("@TipoPrestamo", tipo);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                switch (tipo)
                                {
                                    case "Personal":
                                        PrestamoPersonal personal = new PrestamoPersonal
                                        {
                                            NumeroProducto = reader["NumeroProducto"].ToString(),
                                            CodigoCartera = codigoCartera,
                                            TipoProducto = "Prestamo",
                                            TipoPrestamo = "Personal",
                                            MontoOtorgado = double.Parse(reader["MontoOtorgado"].ToString()),
                                            PlazoMeses = int.Parse(reader["PlazoMeses"].ToString()),
                                            Cuota = double.Parse(reader["Cuota"].ToString()),
                                            FechaLimitePago = Convert.ToDateTime(reader["FechaLimitePago"]),
                                            TasaInteres = double.Parse(reader["TasaInteres"].ToString()),
                                            CuotaSeguro = double.Parse(reader["CuotaSeguro"].ToString()),
                                            NumeroReferencia = reader["NumeroReferencia"].ToString(),
                                            FechaAdquisicion = Convert.ToDateTime(reader["FechaAdquisicion"]),
                                            FechaCierre = reader["FechaCierre"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["FechaCierre"])
                                        };
                                        prestamos.Add(personal);
                                        break;

                                    case "Hipotecario":
                                        PrestamoHipotecario hipotecario = new PrestamoHipotecario
                                        {
                                            NumeroProducto = reader["NumeroProducto"].ToString(),
                                            CodigoCartera = codigoCartera,
                                            TipoProducto = "Prestamo",
                                            TipoPrestamo = "Hipotecario",
                                            MontoOtorgado = double.Parse(reader["MontoOtorgado"].ToString()),
                                            PlazoMeses = int.Parse(reader["PlazoMeses"].ToString()),
                                            Cuota = double.Parse(reader["Cuota"].ToString()),
                                            FechaLimitePago = Convert.ToDateTime(reader["FechaLimitePago"]),
                                            TasaInteres = double.Parse(reader["TasaInteres"].ToString()),
                                            CuotaSeguro = double.Parse(reader["CuotaSeguro"].ToString()),
                                            ValorPropiedad = reader["ValorPropiedad"] != DBNull.Value ? double.Parse(reader["ValorPropiedad"].ToString()) : 0,
                                            TipoPropiedad = reader["TipoPropiedad"] != DBNull.Value ? reader["TipoPropiedad"].ToString() : "",
                                            DireccionPropiedad = reader["DireccionPropiedad"] != DBNull.Value ? reader["DireccionPropiedad"].ToString() : "",
                                            FechaAdquisicion = Convert.ToDateTime(reader["FechaAdquisicion"]),
                                            FechaCierre = reader["FechaCierre"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["FechaCierre"])
                                        };
                                        prestamos.Add(hipotecario);
                                        break;

                                    case "Agropecuario":
                                        PrestamoAgropecuario agro = new PrestamoAgropecuario
                                        {
                                            NumeroProducto = reader["NumeroProducto"].ToString(),
                                            CodigoCartera = codigoCartera,
                                            TipoProducto = "Prestamo",
                                            TipoPrestamo = "Agropecuario",

                                            TipoActividad = reader["TipoActividad"].ToString(),
                                            DescripcionActividad = reader["DescripcionActividad"].ToString(),
                                            MontoOtorgado = double.Parse(reader["MontoOtorgado"].ToString()),
                                            PlazoMeses = int.Parse(reader["PlazoMeses"].ToString()),
                                            Cuota = double.Parse(reader["Cuota"].ToString()),
                                            FechaLimitePago = Convert.ToDateTime(reader["FechaLimitePago"]),
                                            TasaInteres = double.Parse(reader["TasaInteres"].ToString()),
                                            CuotaSeguro = double.Parse(reader["CuotaSeguro"].ToString()),
                                            FechaAdquisicion = Convert.ToDateTime(reader["FechaAdquisicion"]),
                                            FechaCierre = reader["FechaCierre"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["FechaCierre"])
                                        };
                                        prestamos.Add(agro);
                                        break;
                                }
                            }
                        }
                    }
                }
            }

            return prestamos;
        }



        //metodo para obtener las tarjetas
        public List<object> ObtenerTarjetas(string codigoCartera)
        {
            List<object> tarjetas = new List<object>();

            using (SqlConnection conexion = ConexionDb.ObtenerConexion())
            {
                string[] tipos = { "Credito", "Debito" };

                foreach (var tipo in tipos)
                {
                    using (SqlCommand cmd = new SqlCommand("ObtenerTarjetas", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CodigoCartera", codigoCartera);
                        cmd.Parameters.AddWithValue("@TipoTarjeta", tipo);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (tipo == "Credito")
                                {
                                    TarjetaCredito tc = new TarjetaCredito
                                    {
                                        NumeroProducto = reader["NumeroProducto"].ToString(),
                                        NumeroTarjeta = reader["NumeroTarjeta"].ToString(),
                                        TipoTarjeta = reader["TipoTarjeta"].ToString(),
                                        LimiteMonto = reader["LimiteMonto"] == DBNull.Value ? 0 : double.Parse(reader["LimiteMonto"].ToString()),
                                        TipoRed = reader["TipoRed"].ToString(),
                                        Categoria = reader["Categoria"].ToString(),
                                        TasaInteres = reader["TasaInteres"] == DBNull.Value ? 0 : double.Parse(reader["TasaInteres"].ToString()),
                                        CostoMembresia = reader["CostoMembresia"] == DBNull.Value ? 0 : double.Parse(reader["CostoMembresia"].ToString()),
                                        LimiteCredito = reader["LimiteCredito"] == DBNull.Value ? 0 : double.Parse(reader["LimiteCredito"].ToString()),
                                        SaldoUtilizado = reader["SaldoUtilizado"] == DBNull.Value ? 0 : double.Parse(reader["SaldoUtilizado"].ToString()),
                                        PagoMinimo = reader["PagoMinimo"] == DBNull.Value ? 0 : double.Parse(reader["PagoMinimo"].ToString()),
                                        FechaAdquisicion = Convert.ToDateTime(reader["FechaAdquisicion"]),
                                        FechaCierre = reader["FechaCierre"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["FechaCierre"])
                                    };

                                    tarjetas.Add(tc);
                                }
                                else if (tipo == "Debito")
                                {
                                    TarjetaDebito td = new TarjetaDebito
                                    {
                                        NumeroProducto = reader["NumeroProducto"].ToString(),
                                        NumeroTarjeta = reader["NumeroTarjeta"].ToString(),
                                        TipoTarjeta = reader["TipoTarjeta"].ToString(),
                                        SaldoDisponible = reader["SaldoDisponible"] == DBNull.Value ? 0 : double.Parse(reader["SaldoDisponible"].ToString()),
                                        FechaAdquisicion = Convert.ToDateTime(reader["FechaAdquisicion"]),
                                        FechaCierre = reader["FechaCierre"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["FechaCierre"])
                                    };

                                    tarjetas.Add(td);
                                }
                            }
                        }
                    }
                }
            }

            return tarjetas;
        }

        //metodo para insertar cuenta
        public bool CrearProductoFinancieroCuenta(string numeroProducto, string codigoCartera, string tipoCuenta, double saldoInicial,
                                                  List<Beneficiarios> beneficiarios)
        {
            using (SqlConnection conexion = ConexionDb.ObtenerConexion())
            using (SqlTransaction transaccion = conexion.BeginTransaction())

            {


                try
                {
                    //1 producto financiero
                    string queryProducto = @"
                        INSERT INTO ProductoFinancieros (NumeroProducto, CodigoCartera, TipoProducto, FechaAdquisicion, Estado)
                        VALUES (@NumeroProducto, @CodigoCartera, 'Cuenta', GETDATE(), 'Activo')";

                    using (SqlCommand cmd = new SqlCommand(queryProducto, conexion, transaccion))
                    {
                        cmd.Parameters.AddWithValue("@NumeroProducto", numeroProducto);
                        cmd.Parameters.AddWithValue("@CodigoCartera", codigoCartera);
                        cmd.ExecuteNonQuery();
                    }

                    //2 cuenta

                    string queryCuenta = @"
                        INSERT INTO Cuenta (NumeroProducto, TipoCuenta, Saldo)
                        VALUES (@NumeroProducto, @TipoCuenta, @Saldo)";

                    using (SqlCommand cmd = new SqlCommand(queryCuenta, conexion, transaccion))
                    {
                        cmd.Parameters.AddWithValue("@NumeroProducto", numeroProducto);
                        cmd.Parameters.AddWithValue("@TipoCuenta", tipoCuenta);
                        cmd.Parameters.AddWithValue("@Saldo", saldoInicial);
                        cmd.ExecuteNonQuery();
                    }

                    //Para cada beneficiario
                    foreach (var b in beneficiarios)
                    {

                        //ejecutamos insertar, ademas con ouotput devolvemos el id de lo que acabamos de insertar
                        string queryBenef = @"
                            INSERT INTO Beneficiarios (Nombre, Apellido, DUI, Parentesco)
                            OUTPUT INSERTED.IdBeneficiario
                            VALUES (@Nombre, @Apellido, @DUI, @Parentesco)";

                        int idBeneficiario;
                        using (SqlCommand cmd = new SqlCommand(queryBenef, conexion, transaccion))
                        {
                            cmd.Parameters.AddWithValue("@Nombre", b.Nombre);
                            cmd.Parameters.AddWithValue("@Apellido", b.Apellido);
                            cmd.Parameters.AddWithValue("@DUI", b.DUI);
                            cmd.Parameters.AddWithValue("@Parentesco", b.Parentesco ?? (object)DBNull.Value);
                            //ejecuta y retorna la primer fila
                            idBeneficiario = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        //usamos elvalor anterior
                        string queryRelacion = @"
                            INSERT INTO ProductosBeneficiarios (NumeroProducto, IdBeneficiario)
                            VALUES (@NumeroProducto, @IdBeneficiario)";

                        using (SqlCommand cmd = new SqlCommand(queryRelacion, conexion, transaccion))
                        {
                            cmd.Parameters.AddWithValue("@NumeroProducto", numeroProducto);
                            cmd.Parameters.AddWithValue("@IdBeneficiario", idBeneficiario);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaccion.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    MessageBox.Show(ex.ToString());
                    Console.WriteLine("Error al crear el producto financiero: " + ex.Message);
                    return false;
                }
            }
        }

        public bool CrearProductoFinancieroPrestamo(
           string numeroProducto,
    string tipoPrestamo,
    string codigoCartera,
    double montoOtorgado,
    int plazoMeses,
    double cuota,
    DateTime fechaLimitePago,
    double tasaInteres,
    double cuotaSeguro = 0,

    string tipoActividad = null,
    string descripcionActividad = null,
    string tipoPropiedad = null,
    string direccionPropiedad = null,
    double valorPropiedad = 0,
    string numeroReferencia = null
)
        {
            using (SqlConnection conexion = ConexionDb.ObtenerConexion())
            using (SqlTransaction transaccion = conexion.BeginTransaction())

            {

                try
                {

                    //1 Producto financiero
                    string queryProducto = @"
                INSERT INTO ProductoFinancieros 
                (NumeroProducto, CodigoCartera, TipoProducto, FechaAdquisicion, Estado)
                VALUES (@NumeroProducto, @CodigoCartera, 'Prestamo', GETDATE(), 'Activo')";

                    using (SqlCommand cmd = new SqlCommand(queryProducto, conexion, transaccion))
                    {
                        cmd.Parameters.AddWithValue("@NumeroProducto", numeroProducto);
                        cmd.Parameters.AddWithValue("@CodigoCartera", codigoCartera);
                        cmd.ExecuteNonQuery();
                    }


                    //2 tabla prestmao general
                    string queryPrestamo = @"
                INSERT INTO Prestamo 
                (NumeroProducto, TipoPrestamo, MontoOtorgado, SaldoPendiente, PlazoMeses, Cuota, FechaLimitePago, TasaInteres, CuotaSeguro)
                VALUES 
                (@NumeroProducto, @TipoPrestamo, @MontoOtorgado, @SaldoPendiente, @PlazoMeses, @Cuota, @FechaLimitePago, @TasaInteres, @CuotaSeguro)";

                    using (SqlCommand cmd = new SqlCommand(queryPrestamo, conexion, transaccion))
                    {
                        cmd.Parameters.AddWithValue("@NumeroProducto", numeroProducto);
                        cmd.Parameters.AddWithValue("@TipoPrestamo", tipoPrestamo);
                        cmd.Parameters.AddWithValue("@MontoOtorgado", montoOtorgado);
                        cmd.Parameters.AddWithValue("@SaldoPendiente", montoOtorgado);
                        cmd.Parameters.AddWithValue("@PlazoMeses", plazoMeses);
                        cmd.Parameters.AddWithValue("@Cuota", cuota);
                        cmd.Parameters.AddWithValue("@FechaLimitePago", fechaLimitePago);
                        cmd.Parameters.AddWithValue("@TasaInteres", tasaInteres);
                        cmd.Parameters.AddWithValue("@CuotaSeguro", cuotaSeguro);
                        cmd.ExecuteNonQuery();
                    }

                    //evelaur que caso de prestamo estamos insertando

                    switch (tipoPrestamo)
                    {
                        case "Agropecuario":

                            //Para el caso agropecuario
                            string queryAgro = @"
                        INSERT INTO PrestamoAgropecuario (NumeroProducto, TipoActividad, DescripcionActividad)
                        VALUES (@NumeroProducto, @TipoActividad, @DescripcionActividad)";

                            using (SqlCommand cmd = new SqlCommand(queryAgro, conexion, transaccion))
                            {
                                cmd.Parameters.AddWithValue("@NumeroProducto", numeroProducto);
                                cmd.Parameters.AddWithValue("@TipoActividad", tipoActividad ?? "Desconocida");
                                cmd.Parameters.AddWithValue("@DescripcionActividad", descripcionActividad ?? "");
                                cmd.ExecuteNonQuery();
                            }
                            break;

                        //Para el aso de hipotecario

                        case "Hipotecario":
                            string queryHipotecario = @"
                        INSERT INTO PrestamoHipotecario (NumeroProducto, ValorPropiedad, TipoPropiedad, DireccionPropiedad)
                        VALUES (@NumeroProducto, @ValorPropiedad, @TipoPropiedad, @DireccionPropiedad)";

                            using (SqlCommand cmd = new SqlCommand(queryHipotecario, conexion, transaccion))
                            {
                                cmd.Parameters.AddWithValue("@NumeroProducto", numeroProducto);
                                cmd.Parameters.AddWithValue("@ValorPropiedad", valorPropiedad);
                                //si 
                                cmd.Parameters.AddWithValue("@TipoPropiedad", tipoPropiedad ?? "No determinado");
                                cmd.Parameters.AddWithValue("@DireccionPropiedad", direccionPropiedad);
                                cmd.ExecuteNonQuery();
                            }
                            break;

                        //Para el caso personal

                        case "Personal":
                            string queryPersonal = @"
                        INSERT INTO PrestamoPersonal (NumeroProducto, NumeroReferencia)
                        VALUES (@NumeroProducto, @NumeroReferencia)";

                            using (SqlCommand cmd = new SqlCommand(queryPersonal, conexion, transaccion))
                            {
                                cmd.Parameters.AddWithValue("@NumeroProducto", numeroProducto);
                                //si tenemos valor o dejamos nulo
                                cmd.Parameters.AddWithValue("@NumeroReferencia", numeroReferencia ?? "");
                                cmd.ExecuteNonQuery();
                            }
                            break;

                        default:
                            break;
                    }

                    //si todo bien confirmar transaccion
                    transaccion.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    //si algo mal dar vuelta atras
                    transaccion.Rollback();
                    MessageBox.Show(ex.ToString());
                    Console.WriteLine("Error al crear el préstamo: " + ex.Message);
                    return false;
                }
            }
        }


        //metodo para recuperar las cuentas asociadas a un deposito
        public List<Cuenta> RecuperarCuentaDestinoDeposito(string codigoCartera, string tipoCuenta)
        {
            List<Cuenta> cuentas = new List<Cuenta>();

            try
            {
                using (SqlConnection conexion = ConexionDb.ObtenerConexion())
                using (SqlCommand cmd = new SqlCommand("pc_RecuperarCuentaDestino", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CodigoCartera", codigoCartera);
                    cmd.Parameters.AddWithValue("@TipoCuenta", tipoCuenta);


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cuenta cuenta = new Cuenta
                            {
                                NumeroProducto = reader["NumeroProducto"].ToString(),
                                TipoCuenta = reader["TipoCuenta"].ToString(),
                                Saldo = Convert.ToDouble(reader["Saldo"])
                            };

                            cuentas.Add(cuenta);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al recuperar cuentas destino: " + ex.Message);
            }

            return cuentas;
        }
        public List<Tarjeta> RecuperarTarjetasCartera(string codigoCartera)
        {
            List<Tarjeta> tarjetas = new List<Tarjeta>();

            try
            {
                using (SqlConnection conexion = ConexionDb.ObtenerConexion())
                using (SqlCommand cmd = new SqlCommand("pc_RecuperarTarjetasCartera", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CodigoCartera", codigoCartera);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Tarjeta tarjeta = new Tarjeta
                            {
                                NumeroProducto = reader["NumeroProducto"].ToString(),
                                NumeroTarjeta = reader["NumeroTarjeta"].ToString(),
                                TipoTarjeta = reader["TipoTarjeta"].ToString(),
                                LimiteMonto = reader["LimiteMonto"] != DBNull.Value ? Convert.ToDouble(reader["LimiteMonto"]) : 0,
                                TipoRed = reader["TipoRed"].ToString(),
                                Categoria = reader["Categoria"].ToString(),
                                TasaInteres = reader["TasaInteres"] != DBNull.Value ? Convert.ToDouble(reader["TasaInteres"]) : 0,
                                CostoMembresia = reader["CostoMembresia"] != DBNull.Value ? Convert.ToDouble(reader["CostoMembresia"]) : 0,
                                FechaExpiracion = reader["FechaExpiracion"] != DBNull.Value ? Convert.ToDateTime(reader["FechaExpiracion"]) : DateTime.MinValue,
                                CVV = reader["CVV"].ToString(),
                                PIN = reader["PIN"].ToString(),
                                EstadoTarjeta = reader["EstadoTarjeta"].ToString(),
                                SaldoDisponible = reader["SaldoDisponible"] != DBNull.Value ? Convert.ToDouble(reader["SaldoDisponible"]) : 0,
                                LimiteCredito = reader["LimiteCredito"] != DBNull.Value ? Convert.ToDouble(reader["LimiteCredito"]) : 0,
                                SaldoUtilizado = reader["SaldoUtilizado"] != DBNull.Value ? Convert.ToDouble(reader["SaldoUtilizado"]) : 0,
                                MontoDisponible = reader["MontoDisponible"] != DBNull.Value ? Convert.ToDouble(reader["MontoDisponible"]) : 0
                            };

                            tarjetas.Add(tarjeta);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw new Exception("Error al recuperar tarjetas: " + ex.Message);
            }

            return tarjetas;
        }

        //Param recuperar prestamos
        public List<Prestamo> RecuperarPrestamosCartera(string codigoCartera)
        {
            List<Prestamo> prestamos = new List<Prestamo>();

            try
            {
                using (SqlConnection conexion = ConexionDb.ObtenerConexion())
                using (SqlCommand cmd = new SqlCommand("pc_RecuperarPrestamosCartera", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CodigoCartera", codigoCartera);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tipoPrestamo = reader["TipoPrestamo"].ToString();

                            Prestamo prestamo;

                            if (tipoPrestamo.Equals("Personal", StringComparison.OrdinalIgnoreCase))
                            {
                                prestamo = new PrestamoPersonal
                                {
                                    NumeroProducto = reader["NumeroProducto"].ToString(),
                                    CodigoCartera = codigoCartera,
                                    TipoProducto = "Préstamo",
                                    TipoPrestamo = tipoPrestamo,
                                    MontoOtorgado = reader["MontoOtorgado"] != DBNull.Value ? Convert.ToDouble(reader["MontoOtorgado"]) : 0,
                                    PlazoMeses = reader["PlazoMeses"] != DBNull.Value ? Convert.ToInt32(reader["PlazoMeses"]) : 0,
                                    Cuota = reader["Cuota"] != DBNull.Value ? Convert.ToDouble(reader["Cuota"]) : 0,
                                    FechaLimitePago = reader["FechaLimitePago"] != DBNull.Value ? Convert.ToDateTime(reader["FechaLimitePago"]) : DateTime.MinValue,
                                    TasaInteres = reader["TasaInteres"] != DBNull.Value ? Convert.ToDouble(reader["TasaInteres"]) : 0,
                                    CuotaSeguro = reader["CuotaSeguro"] != DBNull.Value ? Convert.ToDouble(reader["CuotaSeguro"]) : 0,
                                    FechaAdquisicion = reader["FechaAdquisicion"] != DBNull.Value ? Convert.ToDateTime(reader["FechaAdquisicion"]) : DateTime.MinValue,
                                    FechaCierre = reader["FechaCierre"] != DBNull.Value ? Convert.ToDateTime(reader["FechaCierre"]) : DateTime.MinValue,
                                    NumeroReferencia = reader["NumeroReferencia"] != DBNull.Value ? reader["NumeroReferencia"].ToString() : "",
                                    SaldoPendiente = reader["SaldoPendiente"] != DBNull.Value ? Convert.ToDouble(reader["SaldoPendiente"]) : 0,

                                };
                            }
                            else if (tipoPrestamo.Equals("Hipotecario", StringComparison.OrdinalIgnoreCase))
                            {
                                prestamo = new PrestamoHipotecario
                                {
                                    NumeroProducto = reader["NumeroProducto"].ToString(),
                                    CodigoCartera = codigoCartera,
                                    TipoProducto = "Préstamo",
                                    TipoPrestamo = tipoPrestamo,
                                    MontoOtorgado = reader["MontoOtorgado"] != DBNull.Value ? Convert.ToDouble(reader["MontoOtorgado"]) : 0,
                                    PlazoMeses = reader["PlazoMeses"] != DBNull.Value ? Convert.ToInt32(reader["PlazoMeses"]) : 0,
                                    Cuota = reader["Cuota"] != DBNull.Value ? Convert.ToDouble(reader["Cuota"]) : 0,
                                    FechaLimitePago = reader["FechaLimitePago"] != DBNull.Value ? Convert.ToDateTime(reader["FechaLimitePago"]) : DateTime.MinValue,
                                    TasaInteres = reader["TasaInteres"] != DBNull.Value ? Convert.ToDouble(reader["TasaInteres"]) : 0,
                                    CuotaSeguro = reader["CuotaSeguro"] != DBNull.Value ? Convert.ToDouble(reader["CuotaSeguro"]) : 0,
                                    FechaAdquisicion = reader["FechaAdquisicion"] != DBNull.Value ? Convert.ToDateTime(reader["FechaAdquisicion"]) : DateTime.MinValue,
                                    FechaCierre = reader["FechaCierre"] != DBNull.Value ? Convert.ToDateTime(reader["FechaCierre"]) : DateTime.MinValue,
                                    ValorPropiedad = reader["ValorPropiedad"] != DBNull.Value ? Convert.ToDouble(reader["ValorPropiedad"]) : 0,
                                    TipoPropiedad = reader["TipoPropiedad"] != DBNull.Value ? reader["TipoPropiedad"].ToString() : "",
                                    DireccionPropiedad = reader["DireccionPropiedad"] != DBNull.Value ? reader["DireccionPropiedad"].ToString() : "",
                                    SaldoPendiente = reader["SaldoPendiente"] != DBNull.Value ? Convert.ToDouble(reader["SaldoPendiente"]) : 0,

                                };
                            }
                            else if (tipoPrestamo.Equals("Agropecuario", StringComparison.OrdinalIgnoreCase))
                            {
                                prestamo = new PrestamoAgropecuario
                                {
                                    NumeroProducto = reader["NumeroProducto"].ToString(),
                                    CodigoCartera = codigoCartera,
                                    TipoProducto = "Préstamo",
                                    TipoPrestamo = tipoPrestamo,
                                    MontoOtorgado = reader["MontoOtorgado"] != DBNull.Value ? Convert.ToDouble(reader["MontoOtorgado"]) : 0,
                                    PlazoMeses = reader["PlazoMeses"] != DBNull.Value ? Convert.ToInt32(reader["PlazoMeses"]) : 0,
                                    Cuota = reader["Cuota"] != DBNull.Value ? Convert.ToDouble(reader["Cuota"]) : 0,
                                    FechaLimitePago = reader["FechaLimitePago"] != DBNull.Value ? Convert.ToDateTime(reader["FechaLimitePago"]) : DateTime.MinValue,
                                    TasaInteres = reader["TasaInteres"] != DBNull.Value ? Convert.ToDouble(reader["TasaInteres"]) : 0,
                                    CuotaSeguro = reader["CuotaSeguro"] != DBNull.Value ? Convert.ToDouble(reader["CuotaSeguro"]) : 0,
                                    FechaAdquisicion = reader["FechaAdquisicion"] != DBNull.Value ? Convert.ToDateTime(reader["FechaAdquisicion"]) : DateTime.MinValue,
                                    FechaCierre = reader["FechaCierre"] != DBNull.Value ? Convert.ToDateTime(reader["FechaCierre"]) : DateTime.MinValue,
                                    TipoActividad = reader["TipoActividad"] != DBNull.Value ? reader["TipoActividad"].ToString() : "",
                                    DescripcionActividad = reader["DescripcionActividad"] != DBNull.Value ? reader["DescripcionActividad"].ToString() : "",
                                    SaldoPendiente = reader["SaldoPendiente"] != DBNull.Value ? Convert.ToDouble(reader["SaldoPendiente"]) : 0,

                                };
                            }
                            else
                            {
                                //generico                             
                                prestamo = new Prestamo
                                {
                                    NumeroProducto = reader["NumeroProducto"].ToString(),
                                    CodigoCartera = codigoCartera,
                                    TipoProducto = "Préstamo",
                                    TipoPrestamo = tipoPrestamo,
                                    MontoOtorgado = reader["MontoOtorgado"] != DBNull.Value ? Convert.ToDouble(reader["MontoOtorgado"]) : 0,
                                    PlazoMeses = reader["PlazoMeses"] != DBNull.Value ? Convert.ToInt32(reader["PlazoMeses"]) : 0,
                                    Cuota = reader["Cuota"] != DBNull.Value ? Convert.ToDouble(reader["Cuota"]) : 0,
                                    FechaLimitePago = reader["FechaLimitePago"] != DBNull.Value ? Convert.ToDateTime(reader["FechaLimitePago"]) : DateTime.MinValue,
                                    TasaInteres = reader["TasaInteres"] != DBNull.Value ? Convert.ToDouble(reader["TasaInteres"]) : 0,
                                    CuotaSeguro = reader["CuotaSeguro"] != DBNull.Value ? Convert.ToDouble(reader["CuotaSeguro"]) : 0,
                                    FechaAdquisicion = reader["FechaAdquisicion"] != DBNull.Value ? Convert.ToDateTime(reader["FechaAdquisicion"]) : DateTime.MinValue,
                                    FechaCierre = reader["FechaCierre"] != DBNull.Value ? Convert.ToDateTime(reader["FechaCierre"]) : DateTime.MinValue
                                };
                            }

                            prestamos.Add(prestamo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw new Exception("Error al recuperar préstamos: " + ex.Message);
            }

            return prestamos;
        }

        //Para transferencia

        public List<Cuenta> BuscarCuentaDestino(string codigoUsuario, out string mensaje)
        {
            List<Cuenta> cuentas = new List<Cuenta>();
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conexion = ConexionDb.ObtenerConexion())
                using (SqlCommand cmd = new SqlCommand("pc_BuscarCuentaDestino", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CodigoUsuario", codigoUsuario);

                    SqlParameter mensajeParam = new SqlParameter("@Mensaje", SqlDbType.NVarChar, 200)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(mensajeParam);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Leer información del usuario destino (primera fila)
                        if (reader.Read())
                        {
                            // Guardar info para mostrar en UI
                            string nombre = reader["Nombre"].ToString();
                            string apellido = reader["Apellido"].ToString();
                            string dui = reader["DUI"].ToString();
                            string codigoCartera = reader["CodigoCartera"].ToString();

                            // Agregar todas las cuentas
                            do
                            {
                                Cuenta cuenta = new Cuenta
                                {
                                    NumeroProducto = reader["NumeroProducto"].ToString(),
                                    TipoCuenta = reader["TipoCuenta"].ToString(),
                                    Saldo = Convert.ToDouble(reader["Saldo"]),
                                    CodigoCartera = codigoCartera,
                                    Estado = reader["Estado"].ToString()
                                };

                                cuentas.Add(cuenta);
                            }
                            while (reader.Read());
                        }
                    }

                    mensaje = mensajeParam.Value.ToString();
                }
            }
            catch (Exception ex)
            {
                mensaje = "Error al buscar cuenta destino: " + ex.Message;
            }

            return cuentas;
        }

    }
}



