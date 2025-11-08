
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using acomprendedoresProyecto.clases;
using acomprendedoresProyecto.pantallas.empleados;
using acomprendedoresProyecto.repositorios;

namespace acomprendedoresProyecto.clases
{
    public class Validacion
    {
        // Validar que el nombre solo contenga letras y tenga más de 2 caracteres
        public bool ValidarNombre(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("El nombre no puede estar vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (texto.Length < 2)
            {
                MessageBox.Show("El nombre debe tener al menos 2 caracteres", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string patron = @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$";
            if (!Regex.IsMatch(texto, patron))
            {
                MessageBox.Show("El nombre solo debe contener letras", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Validar que los apellidos solo contengan letras y tenga más de 2 caracteres
        public bool ValidarApellidos(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("Los apellidos no pueden estar vacíos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (texto.Length < 2)
            {
                MessageBox.Show("Los apellidos deben tener al menos 2 caracteres", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string patron = @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$";
            if (!Regex.IsMatch(texto, patron))
            {
                MessageBox.Show("Los apellidos solo deben contener letras", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Validar DUI con formato: 12345678-9 (solo números)
        public bool ValidarDui(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("El DUI no puede estar vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Patrón: exactamente 8 dígitos, un guión, y exactamente 1 dígito
            string patron = @"^\d{8}-\d{1}$";
            if (!Regex.IsMatch(texto, patron))
            {
                MessageBox.Show("El DUI debe tener el formato: 12345678-9 (solo números)", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Validar teléfono (solo números, 8 dígitos)
        public bool ValidarTelefono(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("El teléfono no puede estar vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string patron = @"^\d{8}$";
            if (!Regex.IsMatch(texto, patron))
            {
                MessageBox.Show("El teléfono debe contener 8 dígitos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Validar correo electrónico
        public bool ValidarCorreo(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("El correo no puede estar vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(texto, patron))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Validar salario (solo números decimales positivos)
        public bool ValidarSalario(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("El salario no puede estar vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            double salario;
            if (!double.TryParse(texto, out salario))
            {
                MessageBox.Show("El salario debe ser un número válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (salario <= 0)
            {
                MessageBox.Show("El salario debe ser mayor a 0", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Validar edad (solo números enteros positivos)
        public bool ValidarEdad(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("La edad no puede estar vacía", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            int edad;
            if (!int.TryParse(texto, out edad))
            {
                MessageBox.Show("La edad debe ser un número válido", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (edad < 18 || edad > 100)
            {
                MessageBox.Show("La edad debe ser mayor a 17 años", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Validar fecha de nacimiento (la persona debe tener 18 años o más)
        public bool ValidarFechaNacimiento(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            // Ajustar la edad si aún no ha cumplido años este año
            if (fechaNacimiento.Date > fechaActual.AddYears(-edad))
            {
                edad--;
            }

            if (edad < 18)
            {
                MessageBox.Show("La persona debe tener al menos 18 años de edad", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (edad > 100)
            {
                MessageBox.Show("La edad no puede ser mayor a 100 años", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Validar dirección (no vacía, mínimo 10 caracteres)
        public bool ValidarDireccion(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("La dirección no puede estar vacía", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (texto.Length < 10)
            {
                MessageBox.Show("La dirección debe tener al menos 10 caracteres", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Validar clave (mínimo 6 caracteres)
        public bool ValidarClave(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("La clave no puede estar vacía", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (texto.Length < 6)
            {
                MessageBox.Show("La clave debe tener al menos 6 caracteres", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Validar campos de ComboBox
        public bool ValidarComboBox(string texto, string nombreCampo)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show($"Debe seleccionar un {nombreCampo}", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Validar departamento (solo letras)
        public bool ValidarDepartamento(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("El departamento no puede estar vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string patron = @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$";
            if (!Regex.IsMatch(texto, patron))
            {
                MessageBox.Show("El departamento solo debe contener letras", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Validar profesión (solo letras)
        public bool ValidarProfesion(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("La profesión no puede estar vacía", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string patron = @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$";
            if (!Regex.IsMatch(texto, patron))
            {
                MessageBox.Show("La profesión solo debe contener letras", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Método para validar todos los campos del formulario de empleado
        public bool ValidarFormularioEmpleado(
            string nombre,
            string apellidos,
            string dui,
            string telefono,
            string correo,
            string direccion,
            string salario,
            string edad,
            string clave,
            string estadoFamiliar,
            string puesto,
            string departamento,
            string profesion)
        {
            if (!ValidarNombre(nombre)) return false;
            if (!ValidarApellidos(apellidos)) return false;
            if (!ValidarDui(dui)) return false;
            if (!ValidarTelefono(telefono)) return false;
            if (!ValidarCorreo(correo)) return false;
            if (!ValidarDireccion(direccion)) return false;
            if (!ValidarSalario(salario)) return false;
            if (!ValidarEdad(edad)) return false;
            if (!ValidarClave(clave)) return false;
            if (!ValidarComboBox(estadoFamiliar, "estado familiar")) return false;
            if (!ValidarComboBox(puesto, "puesto")) return false;
            if (!ValidarDepartamento(departamento)) return false;
            if (!ValidarProfesion(profesion)) return false;

            return true;
        }

        // Método sobrecargado para validar formulario con fecha de nacimiento
        public bool ValidarFormularioEmpleado(
            string nombre,
            string apellidos,
            string dui,
            string telefono,
            string correo,
            string direccion,
            string salario,
            DateTime fechaNacimiento,
            string clave,
            string estadoFamiliar,
            string puesto,
            string departamento,
            string profesion)
        {
            if (!ValidarNombre(nombre)) return false;
            if (!ValidarApellidos(apellidos)) return false;
            if (!ValidarDui(dui)) return false;
            if (!ValidarTelefono(telefono)) return false;
            if (!ValidarCorreo(correo)) return false;
            if (!ValidarDireccion(direccion)) return false;
            if (!ValidarSalario(salario)) return false;
            if (!ValidarFechaNacimiento(fechaNacimiento)) return false;
            if (!ValidarClave(clave)) return false;
            if (!ValidarComboBox(estadoFamiliar, "estado familiar")) return false;
            if (!ValidarComboBox(puesto, "puesto")) return false;
            if (!ValidarDepartamento(departamento)) return false;
            if (!ValidarProfesion(profesion)) return false;

            return true;
        }
    }
}
