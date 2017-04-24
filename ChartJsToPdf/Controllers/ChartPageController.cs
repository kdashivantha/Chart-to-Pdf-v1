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

        public ActionResult Pdf()
        {
            //string url = "http://www.bezanilla-solar.cl/libs/jscripts/DevExpressChartJS/Demos/demos/Charts/Bar%20Series/Simplest%20Chart.html";
            string url =  Request.Url.GetLeftPart(UriPartial.Authority) + "/Chart/BarChart/" ;

            
            string filename = "test.pdf";

            MemoryStream memory = new MemoryStream();
            //Arguments https://wkhtmltopdf.org/usage/wkhtmltopdf.txt
            Dictionary<string, string> args =
                    new Dictionary<string, string>();

            args.Add("javascript-delay", "2000");
            args.Add("enable-javascript", "");
            //--minimum-font-size
            args.Add("minimum-font-size", "12");
            //--width 1000--height 1000
            args.Add("page-width", "720");
            args.Add("page-height", "2000");

            PdfDocument document = new PdfDocument() { Url = url, ExtraParams = args };
            PdfOutput output = new PdfOutput() { OutputStream = memory };
            
            PdfConvert.ConvertHtmlToPdf(document, output);
            memory.Position = 0;

            return File(memory, "application/pdf", Server.UrlEncode(filename));
        }
    }
}