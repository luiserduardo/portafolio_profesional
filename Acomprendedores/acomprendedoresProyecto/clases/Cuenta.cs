using System;

namespace acomprendedoresProyecto.clases
{
    public class Cuenta : ProductoFinancieros
    {
        //private string numeroCuenta; ya se tiene numeroProducto
        private double saldo;
        private string tipoCuenta;

        //public string NumeroCuenta
        //{
        //    get { return numeroCuenta; }
        //    set { numeroCuenta = value; }
        //}

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public string TipoCuenta
        {
            get { return tipoCuenta; }
            set { tipoCuenta = value; }
        }


        public Cuenta() { }
        public Cuenta(string numeroProducto,
              string codigoCartera,
              string tipoProducto,
              string tipoCuenta,
              DateTime fechaAdquisicion,
              DateTime? fechaCierre,
              double saldo,
              string estado)
    : base(numeroProducto, codigoCartera, tipoProducto, fechaAdquisicion, fechaCierre, estado)
{
            TipoCuenta = tipoCuenta;
            Saldo = saldo;
            Estado = estado;
        }



    }
}
