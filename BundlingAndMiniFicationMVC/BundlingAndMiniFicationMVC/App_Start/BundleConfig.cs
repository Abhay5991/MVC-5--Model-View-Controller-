using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;



namespace BundlingAndMiniFicationMVC
{
    public class BundleConfig
    {
        public static void RegisterBuldle(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/js")
                .IncludeDirectory("~/Content/JS","*.js"));

            bundles.Add(new StyleBundle("~/bundle/css").Include("~/Content/styles/Stylesheet1.css", "~/Content/Styles/Stylesheet2.css"));
            //var bundle = new ScriptBundle("~/bundles/js");

            //bundle.Include("~/Content/JS/JavaScript1.js",
            //    "~/Content/JS/JavaScript2.js",
            //    "~/Content/JS/JavaScript3.js",
            //    "~/Content/JS/JavaScript4.js",
            //    "~/Content/JS/JavaScript5.js" );


            //bundles.Add(bundle);

            BundleTable.EnableOptimizations = true;
        }

    }
}