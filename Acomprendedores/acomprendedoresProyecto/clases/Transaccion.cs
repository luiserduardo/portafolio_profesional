using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acomprendedoresProyecto.clases
{
    public class Transaccion : ProductoFinancieros
    {
        private string numeroReferencia;
        private string tipoTransaccion;
        private double montoTransaccion;
        private DateTime fechaTransaccion;
        private string descripcion;

        public string NumeroReferencia
        {
            get { return numeroReferencia; }
            set { numeroReferencia = value; }
        }

        public string TipoTransaccion
        {
            get { return tipoTransaccion; }
            set { tipoTransaccion = value; }
        }

        public double MontoTransaccion
        {
            get { return montoTransaccion; }
            set { montoTransaccion = value; }
        }

        public DateTime FechaTransaccion
        {
            get { return fechaTransaccion; }
            set { fechaTransaccion = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public Transaccion() { }

        public Transaccion(string numeroReferencia, string tipoTransaccion, double montoTransaccion,
                           DateTime fechaTransaccion, string descripcion,
                           string numeroProducto, string codigoCartera, string tipoProducto,
                           DateTime? fechaAdquisicion = null, DateTime? fechaCierre = null)
            : base(numeroProducto, codigoCartera, tipoProducto, fechaAdquisicion, fechaCierre)
        {
            NumeroReferencia = numeroReferencia;
            TipoTransaccion = tipoTransaccion;
            MontoTransaccion = montoTransaccion;
            FechaTransaccion = fechaTransaccion;
            Descripcion = descripcion;
        }
    }
}
