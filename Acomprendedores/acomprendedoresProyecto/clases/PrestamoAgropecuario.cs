using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acomprendedoresProyecto.clases
{
    public class PrestamoAgropecuario : Prestamo
    {
        private string tipoActividad;
        private string descripcionActividad;

        public string TipoActividad
        {
            get { return tipoActividad; }
            set { tipoActividad = value; }
        }

        public string DescripcionActividad
        {
            get { return descripcionActividad; }
            set { descripcionActividad = value; }
        }

        public PrestamoAgropecuario() { }

        public PrestamoAgropecuario(string numeroProducto, string codigoCartera, string tipoProducto,
                                    double montoOtorgado, int plazoMeses, double cuota,
                                    DateTime fechaLimitePago, double tasaInteres, double cuotaSeguro,
                                    string tipoActividad, string descripcionActividad = null,
                                    DateTime? fechaAdquisicion = null, DateTime? fechaCierre = null)
            : base(numeroProducto, codigoCartera, tipoProducto, "Agropecuario",
       montoOtorgado, 0, plazoMeses, cuota, fechaLimitePago,
       tasaInteres, cuotaSeguro, fechaAdquisicion, fechaCierre)

        {
            TipoActividad = tipoActividad;
            DescripcionActividad = descripcionActividad;
        }
    }
}
