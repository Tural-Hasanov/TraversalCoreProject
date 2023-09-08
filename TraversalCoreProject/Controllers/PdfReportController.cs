using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "file1.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();
            Paragraph paragraph = new Paragraph("Traversal Reservasiya Pdf report");

            document.Add(paragraph);
            document.Close();

            return File("/pdfreports/file1.pdf", "application/pdf", "file1.pdf");
        }
        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "file1.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();
            PdfPTable pdfPTable = new PdfPTable(3);
            pdfPTable.AddCell("Qonaq Adı");
            pdfPTable.AddCell("Qonaq Soyadı");
            pdfPTable.AddCell("Qonaq IDCARD");

            pdfPTable.AddCell("Tural");
            pdfPTable.AddCell("Hasanov");
            pdfPTable.AddCell("a1231235");

            pdfPTable.AddCell("Maykl");
            pdfPTable.AddCell("Jordan");
            pdfPTable.AddCell("a123123asdasd5");

            pdfPTable.AddCell("Tezegul");
            pdfPTable.AddCell("Qurbanova");
            pdfPTable.AddCell("asad35");
            document.Add(pdfPTable);
            document.Close();

            return File("/pdfreports/file1.pdf", "application/pdf", "file1.pdf");
        }
    }
}
