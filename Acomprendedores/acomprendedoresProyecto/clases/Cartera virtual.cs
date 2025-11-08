using System;
using System.Collections.Generic;

namespace acomprendedoresProyecto.clases
{
    public class CarteraVirtual
    {
        private string codigoCartera;
        private string codigoCliente;
        private string estado;
        private DateTime fechaCreacion; 

        public string CodigoCartera
        {
            get { return codigoCartera; }
            set { codigoCartera = value; }
        }

        public string CodigoCliente
        {
            get { return codigoCliente; }
            set { codigoCliente = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public DateTime FechaCreacion
        {
            get { return fechaCreacion; }
        }

        public List<ProductoFinancieros> ProductoFinancieros { get; set; }

        public CarteraVirtual()
        {
            Estado = "Activa";
            ProductoFinancieros = new List<ProductoFinancieros>();
        }

        public CarteraVirtual(string codigoCartera, string codigoCliente, string estado = "Activa")
        {
            CodigoCartera = codigoCartera;
            CodigoCliente = codigoCliente;
            Estado = estado;
            ProductoFinancieros = new List<ProductoFinancieros>();
        }

        public void AgregarProducto(ProductoFinancieros producto)
        {
            ProductoFinancieros.Add(producto);
        }

        public string GenerarCodigoCartera(string prefijo, string codigoCliente)
        {
            CodigoCartera = prefijo + "_" + codigoCliente + "_" + new Random().Next(1000, 9999);
            return CodigoCartera;
        }

        public override string ToString()
        {
            return $"{CodigoCartera},{CodigoCliente},{Estado}";
        }
    }
}
