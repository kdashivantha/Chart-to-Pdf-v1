﻿using System.Web;
using System.Web.Optimization;

namespace RotativaService
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/chartjs").Include(
                     "~/Scripts/Chart.min.js",
                     "~/Scripts/CharJsPlugins.js",
                     "~/Scripts/circular-json.js",
                     "~/Scripts/moment.js",
                     "~/Scripts/moment-with-locales.min.js"
                    
                     ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/Site.css",
                      

                      "~/Content/datatables.min.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/StyleSheet.css",
                      "~/Content/layout-client.css"
                      ));
        }
    }
}
