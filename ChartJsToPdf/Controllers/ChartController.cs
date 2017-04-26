using Rotativa.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChartJsToPdf.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BarChart()
        {
            return View();
        }

        public ActionResult CChart()
        {
            return View();
        }


        //https://github.com/webgio/Rotativa/blob/master/Rotativa.Demo/Controllers/HomeController.cs

        public ActionResult Print9()
        {
            //return new Rotativa.ActionAsPdf("CChart");
            return new Rotativa.PartialViewAsPdf("CChart")
            {
                PageSize = Size.A4,
                FileName = "PDF Doc.pdf"
            };
        }
        public ActionResult Print1()
        {

            return new Rotativa.ActionAsPdf("BarChart");
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Print(string pdfCtx)
        {
            ViewBag.HtmlStr = pdfCtx;
            return new Rotativa.PartialViewAsPdf("CanvasTest")
            {
                PageSize = Size.A4,
                FileName = "PDF Doc.pdf"
            };
        }

        
    }
}