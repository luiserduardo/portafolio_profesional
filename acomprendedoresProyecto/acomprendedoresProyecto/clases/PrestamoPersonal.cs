using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acomprendedoresProyecto.clases
{
    public class PrestamoPersonal : Prestamo
    {
        private string numeroReferencia;

        public string NumeroReferencia
        {
            get { return numeroReferencia; }
            set { numeroReferencia = value; }
        }

        public PrestamoPersonal() { }

        public PrestamoPersonal(string numeroProducto, string codigoCartera, string tipoProducto,
                                double montoOtorgado, int plazoMeses, double cuota,
                                DateTime fechaLimitePago, double tasaInteres, double cuotaSeguro,
                                string numeroReferencia,
                                DateTime? fechaAdquisicion = null, DateTime? fechaCierre = null)
           : base(numeroProducto, codigoCartera, tipoProducto, "Personal", montoOtorgado,
       0, plazoMeses, cuota, fechaLimitePago, tasaInteres, cuotaSeguro, fechaAdquisicion, fechaCierre)
        {
            NumeroReferencia = numeroReferencia;
        }

    }
}
