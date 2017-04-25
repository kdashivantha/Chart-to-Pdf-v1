using Codaxy.WkHtmlToPdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChartJsToPdf.Controllers
{
    public class ChartPageController : Controller
    {
        // GET: ChartPage
        public ActionResult Index()
        {
            

            return View();
        }

        public ActionResult Pdf(string url)
        {
            //string url = "http://netdna.webdesignerdepot.com/uploads7/easily-create-stunning-animated-charts-with-chart-js/chartjs-demo.html";
            string url2 =  Request.Url.GetLeftPart(UriPartial.Authority) + "/Chart/CChart/" ;

            //https://github.com/wkhtmltopdf/wkhtmltopdf/issues/1964

            string filename = "test.pdf";

            MemoryStream memory = new MemoryStream();
            //Arguments https://wkhtmltopdf.org/usage/wkhtmltopdf.txt
            Dictionary<string, string> args =
                    new Dictionary<string, string>();

            args.Add("javascript-delay", "1000");
            args.Add("enable-javascript", "");
            //--minimum-font-size
            //args.Add("minimum-font-size", "12");
            //--width 1000--height 1000

            //args.Add("disable-javascript", "");
            //args.Add("page-width", "300mm");
            //args.Add("page-height", "500mm");
            //args.Add("viewport-size", "1280x1024");

            

            PdfDocument document = new PdfDocument() { Url = url, ExtraParams = args };
            PdfOutput output = new PdfOutput() { OutputStream = memory };
            
            PdfConvert.ConvertHtmlToPdf(document, output);
            memory.Position = 0;

            return File(memory, "application/pdf", Server.UrlEncode(filename));
        }


        public ActionResult Print()
        {
            return new Rotativa.ActionAsPdf("../Chart/CChart");
        }
    }
}