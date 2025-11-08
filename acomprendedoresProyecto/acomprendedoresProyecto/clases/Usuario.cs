using System;

namespace acomprendedoresProyecto.clases
{
    public class Usuario
    {
        private string codigoUsuario;
        private string nombre;
        private string apellido;
        private string dUI;
        private string fechaNacimiento;
        private int edad;
        private string correoElectronico;
        private string direccionPersonal;
        private double salarioMensual;
        private string telefono;
        private string clave;
        private string tipoUsuario;
        private string estado;
        public DateTime FechaCreacion
        { get; protected set; }



        //Propiedades publicas
        public string CodigoUsuario
        {
            get { return codigoUsuario; }
            set { codigoUsuario = value; }
        }

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

        public string FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string CorreoElectronico
        {
            get { return correoElectronico; }
            set { correoElectronico = value; }
        }

        public string DireccionPersonal
        {
            get { return direccionPersonal; }
            set { direccionPersonal = value; }
        }

        public double SalarioMensual
        {
            get { return salarioMensual; }
            set { salarioMensual = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        protected string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        protected string TipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }


        public void AsignarFechaCreacion(DateTime fecha)
        {
            FechaCreacion = fecha;
        }


        public string ObtenerClave() { return clave; }
        public string ObtenerTipoUsuario() { return tipoUsuario; }

        public void EstablecerClave(string c) { clave = c; }
        public void EstablecerTipoUsuario(string t) { tipoUsuario = t; }


        //Constructores
        public Usuario()
        {
            estado = "Activo";
        }

        public Usuario(string codigoUsuario, string nombre, string apellido, string dUI,
               string fechaNacimiento, int edad, string correoElectronico,
               string direccionPersonal, double salarioMensual, string telefono,
               string clave, string tipoUsuario, string estado = "Activo")
        {
            CodigoUsuario = codigoUsuario;
            Nombre = nombre;
            Apellido = apellido;
            DUI = dUI;
            FechaNacimiento = fechaNacimiento;
            Edad = edad;
            CorreoElectronico = correoElectronico;
            DireccionPersonal = direccionPersonal;
            SalarioMensual = salarioMensual;
            Telefono = telefono;
            Clave = clave;
            TipoUsuario = tipoUsuario;
            Estado = estado;
        }


        public string GenerarCodigoUsuario(string prefijo, string nombre, string apellidos)
        {
            CodigoUsuario = prefijo + (nombre.Substring(0, 2) + apellidos.Substring(0, 2) + new Random().Next(1000, 9999));
            return CodigoUsuario;
        }

        public int CalcularFecha(DateTime fecha)
        {
            int edad = DateTime.Now.Year - fecha.Year;
            return edad;
        }
    }

}