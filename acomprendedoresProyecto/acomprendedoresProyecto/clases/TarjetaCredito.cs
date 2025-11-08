using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acomprendedoresProyecto.clases
{
    public class TarjetaCredito : Tarjeta
    {
        private double limiteCredito;
        private double saldoUtilizado;
        private string fechaCorte;
        private string fechaPago;
        private double pagoMinimo;

 

        public string FechaCorte
        {
            get { return fechaCorte; }
            set { fechaCorte = value; }
        }

        public string FechaPago
        {
            get { return fechaPago; }
            set { fechaPago = value; }
        }

        public double PagoMinimo
        {
            get { return pagoMinimo; }
            set { pagoMinimo = value; }
        }

        public TarjetaCredito() { }

        public TarjetaCredito(
            string numeroProducto, string fechaAdquisicion, string fechaCierre,
            string numeroTarjeta, string tipoTarjeta, double limiteMonto, string tipoRed,
            string categoria, double tasaInteres, double costoMembresia,
            DateTime fechaExpiracion, string cvv, string pin, string estadoTarjeta = "Activa",
            double limiteCredito = 0, double saldoUtilizado = 0, string fechaCorte = null,
            string fechaPago = null, double pagoMinimo = 0
        )
            : base(numeroProducto, fechaAdquisicion, fechaCierre,
                   numeroTarjeta, tipoTarjeta, limiteMonto, tipoRed,
                   categoria, tasaInteres, costoMembresia,
                   fechaExpiracion, cvv, pin, estadoTarjeta)
        {
            LimiteCredito = limiteCredito;
            SaldoUtilizado = saldoUtilizado;
            FechaCorte = fechaCorte;
            FechaPago = fechaPago;
            PagoMinimo = pagoMinimo;
        }
    }
}
