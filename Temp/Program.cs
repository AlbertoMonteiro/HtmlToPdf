using System;
using System.IO;
using Codaxy.WkHtmlToPdf;

namespace HtmlToPdf
{
    class Program
    {
        static void Main(string[] args)
        {
            var wkHtmlToPdfPath = Path.Combine(Environment.CurrentDirectory, "wkhtmltopdf", "wkhtmltopdf.exe");
            PdfConvert.ConvertHtmlToPdf(new PdfDocument
            {
                Url = "http://wkhtmltopdf.org/"

            }, new PdfConvertEnvironment { WkHtmlToPdfPath = wkHtmlToPdfPath, Timeout = (int)TimeSpan.FromSeconds(60).TotalMilliseconds }, new PdfOutput
            {
                OutputFilePath = "wkhtmltopdf-page.pdf"
            });
            Console.WriteLine("Done");
        }
    }
}
