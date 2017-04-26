using Rotativa.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RotativaService.Controllers
{
    public class GenPdfController : Controller
    {
        // GET: GenPdf
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Print(string domStruct)
        {
            ViewBag.HtmlStr = domStruct;
            return new Rotativa.PartialViewAsPdf("Pdf")
            {
                PageSize = Size.A4,
                FileName = "PDF Doc.pdf",
                
            };
        }
    }
}