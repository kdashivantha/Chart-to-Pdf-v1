using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ChartJsToPdf.Controllers
{
    public class ChartDataController : Controller
    {


        /// <summary>
        /// return buyer data - test
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult> GetBuyerData()
        {
            var data =  @"{""labels"":[""January"",""February"",""March"",""April"",""May"",""June""],""datasets"":[{""backgroundColor"":""rgba(172,204,132,0.8)"",""borderColor"":""#ACC26D"",""pointColor"":""#fff"",""pointStrokeColor"":""#9DB86D"",""data"":[203,156,99,251,305,247]}]}";
            //return this.Content(data, "application/json");
            return Json(new { success = true,feed=data }, JsonRequestBehavior.AllowGet);
        }


        public async Task<ActionResult> GetBarChartData()
        {
            var data = @"{""labels"":[""January"",""February"",""March"",""April"",""May"",""June""],""datasets"":[{""fillColor"":""#48A497"",""strokeColor"":""#48A4D1"",""data"":[456,479,324,569,702,600],""backgroundColor"":[""rgba(255, 99, 132, 1)"",""rgba(54, 162, 235, 1)"",""rgba(255, 206, 86, 1)"",""rgba(75, 192, 192, 1)"",""rgba(153, 102, 255, 1)"",""rgba(255, 159, 64, 1)""],""borderColor"":[""rgba(255,99,132,1)"",""rgba(54, 162, 235, 1)"",""rgba(255, 206, 86, 1)"",""rgba(75, 192, 192, 1)"",""rgba(153, 102, 255, 1)"",""rgba(255, 159, 64, 1)""]},{""fillColor"":""rgba(73,188,170,0.4)"",""strokeColor"":""rgba(72,174,209,0.4)"",""data"":[364,504,605,400,345,320],""backgroundColor"":[""rgba(255, 99, 132, 1)"",""rgba(54, 162, 235, 1)"",""rgba(255, 206, 86, 1)"",""rgba(75, 192, 192, 1)"",""rgba(153, 102, 255, 1)"",""rgba(255, 159, 64, 1)""],""borderColor"":[""rgba(255,99,132,1)"",""rgba(54, 162, 235, 1)"",""rgba(255, 206, 86, 1)"",""rgba(75, 192, 192, 1)"",""rgba(153, 102, 255, 1)"",""rgba(255, 159, 64, 1)""]}]}";
            return Json(new { success = true, feed = data }, JsonRequestBehavior.AllowGet);
        }

        
    }
}