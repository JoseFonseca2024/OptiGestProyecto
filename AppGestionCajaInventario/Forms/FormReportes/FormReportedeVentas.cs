using AppGestionCajaInventario.Class;
using AppGestionCajaInventario.Models.Repository;
using AppGestionCajaInventario.Models.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionCajaInventario.Forms.FormReportes
{
    public partial class FormReportedeVentas : Form
    {
        private readonly IReporteRepository _reporteRepository;
        private readonly ReporteGraficoService _graficoService = new ReporteGraficoService();
        private readonly ReporteExportService _exportService = new ReporteExportService();


        public FormReportedeVentas(IReporteRepository reporteRepository)
        {
            InitializeComponent();
            _reporteRepository = reporteRepository ?? throw new ArgumentNullException(nameof(reporteRepository));
        }

        private async void ibtnGenerar_Click(object sender, EventArgs e)
        {
            int anio = dateTimePicker1.Value.Year;
            var ventas = await _reporteRepository.ObtenerVentasPorAnioAsync(anio);

            dgvVentas.DataSource = ventas;

            _graficoService.GraficarVentasPorDia(formsPlot1, ventas, anio);
        }

        private void ibtnExportar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
                sfd.Title = "Guardar reporte de ventas";
                sfd.FileName = $"ReporteVentas_{dateTimePicker1.Value.Year}.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    int anio = dateTimePicker1.Value.Year;

                    _exportService.ExportarReporte(dgvVentas, formsPlot1, sfd.FileName, anio);

                    MessageBox.Show("Reporte exportado correctamente.", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
