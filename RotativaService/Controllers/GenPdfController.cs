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
            /*
            var doc = new HtmlDocument();
            doc.LoadHtml(domStruct.ToString());
            var scriptNodes = doc.DocumentNode.Descendants("script");

            //todo check
            ViewBag.Scripts = scriptNodes.FirstOrDefault().InnerHtml;

            doc.DocumentNode.Descendants()
                .Where(n => n.Name == "script" || n.Name == "style")
                .ToList()
                .ForEach(n => n.Remove());


            ViewBag.HtmlStr = doc.DocumentNode.InnerHtml;
            */
            //return PartialView("Pdf");

            var pdf = new Rotativa.PartialViewAsPdf("Pdf")
            {
                PageSize = Size.A4,
                FileName = fileName + ".pdf",
                CustomSwitches = "--disable-smart-shrinking --javascript-delay 2000",
                //PageOrientation = Orientation.Landscape,

                PageOrientation = Orientation.Portrait,
                //PageMargins = new Margins(0, 0, 0, 0),
                PageWidth = 210,
                PageHeight = 297
                //CustomSwitches = "--no-stop-slow-scripts --print-media-type --javascript-delay 2000"
            };
            return pdf;

        }
    }
}