using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acomprendedoresProyecto.clases
{
    public class Prestamo : ProductoFinancieros
    {
        private string tipoPrestamo;
        private double montoOtorgado;
        private double saldoPendiente;
        private int plazoMeses;
        private double cuota;
        private DateTime fechaLimitePago;
        private double tasaInteres;
        private double cuotaSeguro;

        public string TipoPrestamo
        {
            get { return tipoPrestamo; }
            set { tipoPrestamo = value; }
        }

        public double MontoOtorgado
        {
            get { return montoOtorgado; }
            set { montoOtorgado = value; }
        }

        public int PlazoMeses
        {
            get { return plazoMeses; }
            set { plazoMeses = value; }
        }

        public double Cuota
        {
            get { return cuota; }
            set { cuota = value; }
        }

        public DateTime FechaLimitePago
        {
            get { return fechaLimitePago; }
            set { fechaLimitePago = value; }
        }

        public double TasaInteres
        {
            get { return tasaInteres; }
            set { tasaInteres = value; }
        }

        public double CuotaSeguro
        {
            get { return cuotaSeguro; }
            set { cuotaSeguro = value; }
        }

        public double SaldoPendiente
        {
            get { return saldoPendiente; }
            set { saldoPendiente = value; }
        }

        public Prestamo() { }
        public Prestamo(string numeroProducto, string codigoCartera, string tipoProducto,
                  string tipoPrestamo, double montoOtorgado, double saldoPendiente,
                  int plazoMeses, double cuota, DateTime fechaLimitePago,
                  double tasaInteres, double cuotaSeguro = 0,
                  DateTime? fechaAdquisicion = null, DateTime? fechaCierre = null)

              : base(numeroProducto, codigoCartera, tipoProducto, fechaAdquisicion, fechaCierre)
        {
            TipoPrestamo = tipoPrestamo;
            MontoOtorgado = montoOtorgado;
            SaldoPendiente = saldoPendiente;
            PlazoMeses = plazoMeses;
            Cuota = cuota;
            FechaLimitePago = fechaLimitePago;
            TasaInteres = tasaInteres;
            CuotaSeguro = cuotaSeguro;
        }
    }
}
