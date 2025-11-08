using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using acomprendedoresProyecto.repositorios;
using System.IO;

namespace acomprendedoresProyecto.interfaz.reporte
{
    public partial class Reporte : Form
    {
        string codigoCartera;
        ReporteRepositorio repositorio;

        public Reporte(string codigoCartera)
        {
            InitializeComponent();
            this.codigoCartera = codigoCartera;
            this.repositorio = new ReporteRepositorio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicio = dateTimePicker1.Value.Date;
                DateTime fechaFin = dateTimePicker2.Value.Date;

                if (fechaFin < fechaInicio)
                {
                    MessageBox.Show("La fecha final no puede ser menor que la fecha de inicio.",
                        "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string mensaje;
                DataTable dtTransacciones = repositorio.ObtenerTransaccionesPorFecha(
                    codigoCartera,
                    fechaInicio,
                    fechaFin,
                    out mensaje);

                if (dtTransacciones == null || dtTransacciones.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron transacciones en el rango de fechas seleccionado.\n\n" + mensaje,
                        "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar el reporte
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.RefreshReport();
                    return;
                }

              
                string rutaReporte = Path.Combine(Application.StartupPath, "interfaz", "reporte", "ReporteTransacciones.rdlc");

                if (!File.Exists(rutaReporte))
                {
                    string rutaProyecto = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\interfaz\reporte\ReporteTransacciones.rdlc"));

                    if (File.Exists(rutaProyecto))
                    {
                        rutaReporte = rutaProyecto;
                    }
                    else
                    {
                        MessageBox.Show("No se encuentra el archivo del reporte.\n\n" +
                            "Rutas buscadas:\n" +
                            $"1. {rutaReporte}\n" +
                            $"2. {rutaProyecto}\n\n" +
                            "Por favor, verifica la configuración del archivo .rdlc",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                reportViewer1.LocalReport.ReportPath = rutaReporte;

                reportViewer1.LocalReport.DataSources.Clear();

                ReportDataSource rds = new ReportDataSource("DataSetTransacciones", dtTransacciones);
                reportViewer1.LocalReport.DataSources.Add(rds);

                ReportParameter[] parametros = new ReportParameter[]
                {
            new ReportParameter("CodigoCartera", codigoCartera),
            new ReportParameter("FechaInicio", fechaInicio.ToString("dd/MM/yyyy")),
            new ReportParameter("FechaFin", fechaFin.ToString("dd/MM/yyyy"))
                };
                reportViewer1.LocalReport.SetParameters(parametros);

                reportViewer1.RefreshReport();

              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte:\n\n" + ex.Message + "\n\n" + ex.StackTrace,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now.AddMonths(-1);
            dateTimePicker2.Value = DateTime.Now;

          
        }
    }
}