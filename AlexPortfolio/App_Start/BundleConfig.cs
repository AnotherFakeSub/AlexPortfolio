﻿using System.Web;
using System.Web.Optimization;

namespace AlexPortfolio
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css/portfolio").Include(
                "~/Content/portfolio-master.css"));

            bundles.Add(new StyleBundle("~/Content/css/bootstrap").Include(
                "~/Content/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/Content/css/font-awesome").Include(
                "~/Content/font-awesome.css"));    

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/popper.min.js",
                "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/popper").Include(
                "~/Scripts/popper.min.js"));                                 

            bundles.Add(new ScriptBundle("~/bundles/portfolio").Include(
                "~/Scripts/portfolio-master.js"));
        }
    }
}
