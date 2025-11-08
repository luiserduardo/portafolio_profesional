using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acomprendedoresProyecto.clases
{
    public class TarjetaDebito : Tarjeta
    {
        private double saldoDisponible;

        public double SaldoDisponible
        {
            get { return saldoDisponible; }
            set { saldoDisponible = value; }
        }

        public TarjetaDebito() { }

        public TarjetaDebito(
            string numeroProducto, string fechaAdquisicion, string fechaCierre,
            string numeroTarjeta, string tipoTarjeta, double limiteMonto, string tipoRed,
            string categoria, double tasaInteres, double costoMembresia,
            DateTime fechaExpiracion, string cvv, string pin, string estadoTarjeta = "Activa",
            double saldoDisponible = 0
        )
            : base(numeroProducto, fechaAdquisicion, fechaCierre,
                   numeroTarjeta, tipoTarjeta, limiteMonto, tipoRed,
                   categoria, tasaInteres, costoMembresia,
                   fechaExpiracion, cvv, pin, estadoTarjeta)
        {
            SaldoDisponible = saldoDisponible;
        }
    }
}
