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


        public ActionResult Print()
        {
            var dd = new Rotativa.WkhtmltopdfDriver();
           
            //return new Rotativa.ActionAsPdf("CChart");
            return new Rotativa.PartialViewAsPdf("CChart")
            {
                
                PageSize = Size.A4,
                FileName = "PDF Doc.pdf"
            };
        }
    }
}