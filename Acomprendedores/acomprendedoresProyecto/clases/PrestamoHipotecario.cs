using acomprendedoresProyecto.clases;
using System;

public class PrestamoHipotecario : Prestamo
{
    private double valorPropiedad;
    private string tipoPropiedad;
    private string direccionPropiedad;

 
    public double ValorPropiedad
    {
        get { return valorPropiedad; }
        set { valorPropiedad = value; }
    }

    public string TipoPropiedad
    {
        get { return tipoPropiedad; }
        set { tipoPropiedad = value; }
    }

    public string DireccionPropiedad
    {
        get { return direccionPropiedad; }
        set { direccionPropiedad = value; }
    }


    public PrestamoHipotecario() { }

    public PrestamoHipotecario(string numeroProducto, string codigoCartera, string tipoProducto,
                               double montoOtorgado, int plazoMeses, double cuota,
                               DateTime fechaLimitePago, double tasaInteres, double cuotaSeguro,
                               double valorPropiedad, string tipoPropiedad, string direccionPropiedad = null,
                               DateTime? fechaAdquisicion = null, DateTime? fechaCierre = null)
       : base(numeroProducto, codigoCartera, tipoProducto, "Hipotecario", montoOtorgado,
       0, plazoMeses, cuota, fechaLimitePago, tasaInteres, cuotaSeguro, fechaAdquisicion, fechaCierre)
    {
        ValorPropiedad = valorPropiedad;
        TipoPropiedad = tipoPropiedad;
        DireccionPropiedad = direccionPropiedad;
    }


}
