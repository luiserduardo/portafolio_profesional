using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acomprendedoresProyecto.pantallas.productoFinanciero.Prestamo.DatosEspecificos.Personal
{
    public partial class DatosPersonal : UserControl
    {
        public DatosPersonal()
        {
            InitializeComponent();
            txtNumeroReferencia.Text = GenerarNumeroReferenciaRandom();
        }

        private string GenerarNumeroReferenciaRandom()
        {
            Random rnd = new Random();
            int numero = rnd.Next(0, 10000); 
            return $"REF-PER-{numero.ToString("D4")}";
        }


    }
}
