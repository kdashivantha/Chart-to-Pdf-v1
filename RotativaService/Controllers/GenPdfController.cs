using HtmlAgilityPack;
using Rotativa.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace RotativaService.Controllers
{
    public class GenPdfController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Print(string domStruct, string fileName)
        {
            ViewBag.HtmlStr = domStruct.ToString();

            HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(domStruct);
            var script = doc.DocumentNode.Descendants()
                                         .Where(n => n.Name == "script")
                                         .FirstOrDefault();


            ViewBag.HtmlScript = script != null ? script.InnerText:"";

            //footer html
            // http://stackoverflow.com/questions/15250505/displaying-headers-and-footers-in-a-pdf-generated-by-rotativa

            var pdf = new Rotativa.PartialViewAsPdf("Pdf")
            {
                PageSize = Size.A4,
                FileName = fileName + ".pdf",
                CustomSwitches = "--disable-smart-shrinking --javascript-delay 2000",// --header-right \"Page[page] of[toPage]\"",
                //PageOrientation = Orientation.Landscape,

                PageOrientation = Orientation.Portrait,
                //PageMargins = new Margins(0, 0, 0, 0), //defalut 10mm margins
                PageWidth = 210,
                PageHeight = 297
                //CustomSwitches = "--no-stop-slow-scripts --print-media-type --javascript-delay 2000"
            };
            return pdf;

        }
    }
}