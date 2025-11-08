using System;
using System.Collections.Generic;

namespace acomprendedoresProyecto.clases
{
    public class ProductoFinancieros
    {
        private string numeroProducto;
        private string codigoCartera;
        private string tipoProducto; 
        private DateTime fechaAdquisicion;
        private DateTime? fechaCierre; 
        private string estado; 

        public string NumeroProducto
        {
            get { return numeroProducto; }
            set { numeroProducto = value; }
        }

        public string CodigoCartera
        {
            get { return codigoCartera; }
            set { codigoCartera = value; }
        }

        public string TipoProducto
        {
            get { return tipoProducto; }
            set { tipoProducto = value; }
        }

        public DateTime FechaAdquisicion
        {
            get { return fechaAdquisicion; }
            set { fechaAdquisicion = value; }
        }

        public DateTime? FechaCierre
        {
            get { return fechaCierre; }
            set { fechaCierre = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public List<Beneficiarios> Beneficiarios { get; set; }

        public ProductoFinancieros()
        {
            Estado = "Activo";
            Beneficiarios = new List<Beneficiarios>();
        }

        public ProductoFinancieros(string numeroProducto, string codigoCartera,
                                   string tipoProducto, DateTime? fechaAdquisicion = null,
                                   DateTime? fechaCierre = null, string estado = "Activo")
        {
            NumeroProducto = numeroProducto;
            CodigoCartera = codigoCartera;
            TipoProducto = tipoProducto;
            FechaAdquisicion = fechaAdquisicion ?? DateTime.Now; 
            FechaCierre = fechaCierre;
            Estado = estado;
            Beneficiarios = new List<Beneficiarios>();
        }

        public void AgregarBeneficiario(Beneficiarios beneficiario)
        {
            Beneficiarios.Add(beneficiario);
        }

        public override string ToString()
        {
            return $"{NumeroProducto},{CodigoCartera},{TipoProducto}," +
                   $"{FechaAdquisicion.ToShortDateString()},{FechaCierre?.ToShortDateString()},{Estado}";
        }
    }
}
