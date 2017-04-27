using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pechkin.Synchronized.Controllers
{
    public class GenPdfController : Controller
    {
        // GET: GenPdf
        public ActionResult Index()
        {
            // Simple PDF from String
            //test text to merge
            //byte[] pdfBuffer = new SimplePechkin(new GlobalConfig()).Convert("<html><body><h1>Hello world!</h1></body></html>");

            byte[] pdfBuffer = new SimplePechkin(new GlobalConfig()).Convert(
                @"<!DOCTYPE html><html lang=""en""><head> <meta charset=""utf-8""/> <title>Chart.js demo</title> <script src='/Scripts/chart/Chart.min.js'></script></head><body> <a href=""/ChartPage/Pdf?url=http://localhost:55314/Chart/CChart/"" target=""_blank"">Download Pdf</a> <br/><br/> <canvas id=""buyers"" width=""600"" height=""400""></canvas> <canvas id=""countries"" width=""600"" height=""400""></canvas> <canvas id=""income"" width=""600"" height=""400""></canvas> <canvas id=""income1"" width=""600"" height=""400""></canvas> <canvas id=""income2"" width=""600"" height=""400""></canvas> <canvas id=""income3"" width=""600"" height=""400""></canvas> <script>// line chart datavar buyerData={labels : [""January"",""February"",""March"",""April"",""May"",""June""],datasets : [{fillColor : ""rgba(172,194,132,0.4)"",strokeColor : ""#ACC26D"",pointColor : ""#fff"",pointStrokeColor : ""#9DB86D"",data : [203,156,99,251,305,247]}]}// get line chart canvasvar buyers=document.getElementById('buyers').getContext('2d');// draw line chartnew Chart(buyers).Line(buyerData);// pie chart datavar pieData=[{value: 20,color:""#878BB6""},{value : 40,color : ""#4ACAB4""},{value : 10,color : ""#FF8153""},{value : 30,color : ""#FFEA88""}];// pie chart optionsvar pieOptions={segmentShowStroke : false,animateScale : true}// get pie chart canvasvar countries=document.getElementById(""countries"").getContext(""2d"");// draw pie chartnew Chart(countries).Pie(pieData, pieOptions);// bar chart datavar barData={labels : [""January"",""February"",""March"",""April"",""May"",""June""],datasets : [{fillColor : ""#48A497"",strokeColor : ""#48A4D1"",data : [456,479,324,569,702,600]},{fillColor : ""rgba(73,188,170,0.4)"",strokeColor : ""rgba(72,174,209,0.4)"",data : [364,504,605,400,345,320]}]}// get bar chart canvasvar income=document.getElementById(""income"").getContext(""2d"");// draw bar chartnew Chart(income).Bar(barData);// draw bar chartnew Chart(document.getElementById(""income1"").getContext(""2d"")).Bar(barData);new Chart(document.getElementById(""income2"").getContext(""2d"")).Bar(barData);new Chart(document.getElementById(""income3"").getContext(""2d"")).Bar(barData); </script><script type=""application/json"" id=""__browserLink_initializationData"">{""appName"":""Chrome"",""requestId"":""6df72eabad1d40d09053758472115e2b""}</script><script type=""text/javascript"" src=""http://localhost:55777/bf9174e9c93b4012ba0782edda9b2a68/browserLink"" async=""async""></script></body></html>"
                );


            string filename = "hello_world.pdf";
            string abc = "sdsfs.abc";

            Response.Clear();

            Response.ClearContent();
            Response.ClearHeaders();

            Response.ContentType = "application/pdf";
            Response.AddHeader("Content-Disposition", string.Format("attachment;filename=test.pdf; size={0}", pdfBuffer.Length));
            Response.BinaryWrite(pdfBuffer);

            Response.Flush();
            Response.End();

            return File(pdfBuffer, "application/pdf");
        }


    }
}
