using AppGestionCajaInventario.Models.Dto.Reporte;
using ScottPlot;
using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCajaInventario.Class
{
   public class ReporteGraficoService
   {
        public void GraficarVentasPorDia(FormsPlot plot, List<VentaReporteDto> ventas, int anio)
        {
            var datosPorDia = ventas
                .GroupBy(v => v.FechaMovimiento.Date)
                .Select(g => new { Fecha = g.Key, Total = g.Sum(x => x.Monto) })
                .OrderBy(x => x.Fecha)
                .ToList();

            if (!datosPorDia.Any())
            {
                plot.Plot.Clear();
                plot.Plot.Title($"Sin datos para {anio}");
                plot.Refresh();
                return;
            }

            double[] xs = datosPorDia.Select(d => d.Fecha.ToOADate()).ToArray();
            double[] ys = datosPorDia.Select(d => (double)d.Total).ToArray();

            plot.Plot.Clear();
            plot.Plot.AddScatter(xs, ys);
            plot.Plot.XAxis.DateTimeFormat(true);
            plot.Plot.Title($"Ventas por día - {anio}");
            plot.Plot.YLabel("Monto (C$)");
            plot.Plot.XLabel("Fecha");
            plot.Refresh();
        }

        public void GraficarVentasPorMes(FormsPlot plot, List<VentaReporteDto> ventas, int anio)
        {
            var datosPorMes = ventas
                .GroupBy(v => v.FechaMovimiento.Month)
                .Select(g => new { Mes = g.Key, Total = g.Sum(x => x.Monto) })
                .OrderBy(x => x.Mes)
                .ToList();

            if (!datosPorMes.Any())
            {
                plot.Plot.Clear();
                plot.Plot.Title($"Sin datos para {anio}");
                plot.Refresh();
                return;
            }

            double[] xs = datosPorMes.Select(d => (double)d.Mes).ToArray();
            double[] ys = datosPorMes.Select(d => (double)d.Total).ToArray();

            plot.Plot.Clear();
            plot.Plot.AddBar(xs, ys);
            plot.Plot.Title($"Ventas por mes - {anio}");
            plot.Plot.YLabel("Monto (C$)");
            plot.Plot.XLabel("Mes");
            plot.Refresh();
        }
    }
}

