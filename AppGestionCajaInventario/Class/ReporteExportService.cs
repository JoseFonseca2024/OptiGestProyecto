using ClosedXML.Excel;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Class
{
    public class ReporteExportService
    {
        public void ExportarReporte(DataGridView dgv, FormsPlot graficoDia, string rutaArchivo, int anio)
        {
            using (var wb = new XLWorkbook())
            {
                // Hoja 1: Datos del DataGridView
                var wsDatos = wb.Worksheets.Add("Ventas");
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    wsDatos.Cell(1, i + 1).Value = dgv.Columns[i].HeaderText;
                    wsDatos.Cell(1, i + 1).Style.Font.Bold = true;
                    wsDatos.Cell(1, i + 1).Style.Fill.BackgroundColor = XLColor.LightGray;
                }

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        var valor = dgv.Rows[i].Cells[j].Value;
                        wsDatos.Cell(i + 2, j + 1).Value = valor?.ToString() ?? string.Empty;
                    }
                }
                wsDatos.Columns().AdjustToContents();

                var wsGraficoDia = wb.Worksheets.Add("GraficoDia");
                string imgDia = Path.Combine(Path.GetTempPath(), "graficoDia.png");
                graficoDia.Plot.SaveFig(imgDia);
                wsGraficoDia.Cell(1, 2).Value = $"Ventas por día - {anio}";
                wsGraficoDia.Cell(1, 2).Style.Font.Bold = true;
                wsGraficoDia.AddPicture(imgDia).MoveTo(wsGraficoDia.Cell(2, 2)).Scale(0.8);

                wb.SaveAs(rutaArchivo);
            }
        }
    }
}
