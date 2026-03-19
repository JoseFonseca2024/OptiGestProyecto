using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using AppGestionCajaInventario.Models.Dto.Documentos;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace AppGestionCajaInventario.Class
{
    public class DocumentoPDFService
    {
        private static readonly iTextSharp.text.Font FontTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
        private static readonly iTextSharp.text.Font FontNormal = FontFactory.GetFont(FontFactory.HELVETICA, 11);
        private static readonly CultureInfo CultureInfo = new CultureInfo("es-ES");
        private const float Margin = 40f;

        public void GenerarDocumentoPdf(DocumentoResponseDto documento, string rutaArchivo)
        {
            if (documento == null || string.IsNullOrWhiteSpace(rutaArchivo))
                throw new ArgumentException("Parámetros inválidos para generar el PDF.");

            using (var fileStream = new FileStream(rutaArchivo, FileMode.Create))
            {
                var doc = new Document(PageSize.A4, Margin, Margin, Margin, Margin);
                PdfWriter.GetInstance(doc, fileStream);
                doc.Open();

                AgregarEncabezado(doc, documento);
                AgregarTablaProductos(doc, documento.Detalles);
                AgregarTotales(doc, documento);

                doc.Close();
            }

            AbrirPdf(rutaArchivo);
        }

        private void AgregarEncabezado(Document doc, DocumentoResponseDto documento)
        {
            var header = new PdfPTable(3) { WidthPercentage = 100 };
            header.AddCell(new PdfPCell(new Phrase($"Documento: {documento.NumeroDocumento}", FontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
            header.AddCell(new PdfPCell(new Phrase(documento.EmpresaNombre, FontTitulo)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_CENTER });
            header.AddCell(new PdfPCell(new Phrase($"Fecha: {documento.FechaDocumento:dd/MM/yyyy}", FontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });

            doc.Add(header);

            var ruc = new Paragraph($"RUC: {documento.EmpresaRUC}", FontNormal) { Alignment = Element.ALIGN_CENTER };
            doc.Add(ruc);
            doc.Add(new Paragraph("\n"));

            var clienteTable = new PdfPTable(2) { WidthPercentage = 100 };
            clienteTable.AddCell(new PdfPCell(new Phrase("Cliente:", FontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_LEFT });
            clienteTable.AddCell(new PdfPCell(new Phrase(documento.ClienteNombre, FontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_LEFT });
            clienteTable.AddCell(new PdfPCell(new Phrase("Teléfono:", FontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_LEFT });
            clienteTable.AddCell(new PdfPCell(new Phrase(documento.ClienteTelefono ?? "No especificado", FontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_LEFT });

            doc.Add(clienteTable);
            doc.Add(new Paragraph("\n"));
        }

        private void AgregarTablaProductos(Document doc, List<DetalleDocumentoDto> detalles)
        {
            var table = new PdfPTable(6) { WidthPercentage = 100 };

            table.SetWidths(new float[] { 15f, 35f, 15f, 10f, 10f, 15f });

            table.AddCell(new PdfPCell(new Phrase("Código", FontNormal)) { BackgroundColor = BaseColor.LIGHT_GRAY });
            table.AddCell(new PdfPCell(new Phrase("Producto", FontNormal)) { BackgroundColor = BaseColor.LIGHT_GRAY });
            table.AddCell(new PdfPCell(new Phrase("Precio", FontNormal)) { BackgroundColor = BaseColor.LIGHT_GRAY });
            table.AddCell(new PdfPCell(new Phrase("Cantidad", FontNormal)) { BackgroundColor = BaseColor.LIGHT_GRAY });
            table.AddCell(new PdfPCell(new Phrase("Descuento %", FontNormal)) { BackgroundColor = BaseColor.LIGHT_GRAY });
            table.AddCell(new PdfPCell(new Phrase("Total", FontNormal)) { BackgroundColor = BaseColor.LIGHT_GRAY });

            foreach (var d in detalles)
            {
                decimal subtotal = d.Cantidad * d.PrecioUnitario;
                decimal descuento = subtotal * (d.PorcentajeDescuento / 100);
                decimal totalLinea = subtotal - descuento;

                table.AddCell(d.CodigoProducto);
                table.AddCell(d.NombreProducto);
                table.AddCell(d.PrecioUnitario.ToString("N2", CultureInfo));
                table.AddCell(d.Cantidad.ToString(CultureInfo));
                table.AddCell(d.PorcentajeDescuento.ToString("N2", CultureInfo));
                table.AddCell(totalLinea.ToString("N2", CultureInfo));
            }

            doc.Add(table);
            doc.Add(new Paragraph("\n"));
        }

        private void AgregarTotales(Document doc, DocumentoResponseDto documento)
        {
            var totales = new PdfPTable(2)
            {
                WidthPercentage = 40,
                HorizontalAlignment = Element.ALIGN_RIGHT
            };

            totales.AddCell("Subtotal:");
            totales.AddCell(documento.Subtotal.ToString("N2", CultureInfo));

            totales.AddCell("IVA:");
            totales.AddCell(documento.IVA.ToString("N2", CultureInfo));

            totales.AddCell("Total Factura:");
            totales.AddCell(documento.TotalFactura.ToString("N2", CultureInfo));

            doc.Add(totales);
        }


        private void AbrirPdf(string rutaArchivo)
        {
            var psi = new ProcessStartInfo
            {
                FileName = rutaArchivo,
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }
}
