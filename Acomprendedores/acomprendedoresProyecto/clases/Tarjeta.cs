using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acomprendedoresProyecto.clases
{
    public class Tarjeta : ProductoFinancieros
    {
        private string numeroTarjeta;
        private string tipoTarjeta;
        private double limiteMonto;
        private string tipoRed;
        private string categoria;
        private double tasaInteres;
        private double costoMembresia;
        private DateTime fechaExpiracion;
        private string cvv;
        private string pin;
        private string estadoTarjeta;

        private double saldoDisponible;      
        private double limiteCredito;        
        private double saldoUtilizado;       
        private double montoDisponible;      

        public string NumeroTarjeta
        {
            get { return numeroTarjeta; }
            set { numeroTarjeta = value; }
        }

        public string TipoTarjeta
        {
            get { return tipoTarjeta; }
            set { tipoTarjeta = value; }
        }

        public double LimiteMonto
        {
            get { return limiteMonto; }
            set { limiteMonto = value; }
        }

        public string TipoRed
        {
            get { return tipoRed; }
            set { tipoRed = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public double TasaInteres
        {
            get { return tasaInteres; }
            set { tasaInteres = value; }
        }

        public double CostoMembresia
        {
            get { return costoMembresia; }
            set { costoMembresia = value; }
        }

        public DateTime FechaExpiracion
        {
            get { return fechaExpiracion; }
            set { fechaExpiracion = value; }
        }

        public string CVV
        {
            get { return cvv; }
            set { cvv = value; }
        }

        public string PIN
        {
            get { return pin; }
            set { pin = value; }
        }

        public string EstadoTarjeta
        {
            get { return estadoTarjeta; }
            set { estadoTarjeta = value; }
        }

        public double SaldoDisponible
        {
            get { return saldoDisponible; }
            set { saldoDisponible = value; }
        }

        public double LimiteCredito
        {
            get { return limiteCredito; }
            set { limiteCredito = value; }
        }

        public double SaldoUtilizado
        {
            get { return saldoUtilizado; }
            set { saldoUtilizado = value; }
        }

        public double MontoDisponible
        {
            get { return montoDisponible; }
            set { montoDisponible = value; }
        }


        public Tarjeta() { }
        public Tarjeta(string numeroProducto, string fechaAdquisicion, string fechaCierre,
                       string numeroTarjeta, string tipoTarjeta, double limiteMonto, string tipoRed,
                       string categoria, double tasaInteres, double costoMembresia,
                       DateTime fechaExpiracion, string cvv, string pin, string estadoTarjeta = "Activa")
            : base(numeroProducto, fechaAdquisicion, fechaCierre)
        {
            NumeroTarjeta = numeroTarjeta;
            TipoTarjeta = tipoTarjeta;
            LimiteMonto = limiteMonto;
            TipoRed = tipoRed;
            Categoria = categoria;
            TasaInteres = tasaInteres;
            CostoMembresia = costoMembresia;
            FechaExpiracion = fechaExpiracion;
            CVV = cvv;
            PIN = pin;
            EstadoTarjeta = estadoTarjeta;
        }
    }}