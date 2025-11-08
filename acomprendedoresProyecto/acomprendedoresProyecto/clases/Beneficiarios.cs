using System;

namespace acomprendedoresProyecto.clases
{
    public class Beneficiarios
    {
        private string nombre;
        private string apellido;
        private string dUI;
        private DateTime fechaRegistro;
        public string Parentesco {  get; set; }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string DUI
        {
            get { return dUI; }
            set { dUI = value; }
        }

        public DateTime FechaRegistro
        {
            get { return fechaRegistro; }
        }

        public Beneficiarios()
        {
        }

        public Beneficiarios(string nombre, string apellido, string dUI, string parentesco)
        {
            Nombre = nombre;
            Apellido = apellido;
            DUI = dUI;
            Parentesco = parentesco;
        }

        public override string ToString()
        {
            return $"{Nombre},{Apellido},{DUI}";
        }
    }
}
