using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acomprendedoresProyecto.clases
{
    public class Empleado : Usuario
    {
        private string estadoFamiliar;
        private string puesto;
        private string departamento;
        private string profesion;
        public string FechaContratacion { get; protected set; }


        public string EstadoFamiliar
        {
            get { return estadoFamiliar; }
            set { estadoFamiliar = value; }
        }

        public string Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }

        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }

        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }

        public void AsignarFechaContratacion(string fecha)
        {
            FechaContratacion = fecha;
        }


        public Empleado(
            string codigoUsuario, string nombre, string apellido, string dUI,
            string fechaNacimiento, int edad, string correoElectronico,
            string direccionPersonal, double salarioMensual, string telefono,
            string clave, string tipoUsuario, 
            string estadoFamiliar, string puesto, string departamento, string profesion, string estado = "Activo"
 ) : base(codigoUsuario, nombre, apellido, dUI, fechaNacimiento, edad,
                 correoElectronico, direccionPersonal, salarioMensual, telefono,
                 clave, tipoUsuario, estado)
        {
            EstadoFamiliar = estadoFamiliar;
            Puesto = puesto;
            Departamento = departamento;
            Profesion = profesion;
        }


        public override string ToString()
        {
            return $"{CodigoUsuario},{Nombre},{Apellido},{DUI},{FechaNacimiento}," +
                   $"{Edad},{CorreoElectronico},{DireccionPersonal}," +
                   $"{SalarioMensual},{Telefono},{Clave},{TipoUsuario}," +
                   $"{EstadoFamiliar},{Puesto},{Departamento},{Profesion},{Estado}";
        }
    }
}
