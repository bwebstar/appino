using System.Web;
using System.Web.Optimization;

namespace Appino
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/custom").Include(
              "~/Content/js/owl-carousel/owl.carousel.min.js",
              "~/Content/js/counter/jquery.countTo.js",
              "~/Content/js/jquery.appear.js",
              "~/Content/js/magnific-popup/jquery.magnific-popup.min.js",
              "~/Content/js/retina.min.js",
              "~/Content/js/wow.min.js",
              "~/Content/js/jquery.countdown.min.js",
              "~/Content/js/custom.js"
          ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/css/owl-carousel/owl.carousel.css",
                "~/Content/css/font-awesome.css",
                "~/Content/css/magnific-popup/magnific-popup.css",
                "~/Content/css/animate.css",
                "~/Content/css/ionicons.min.css",
                "~/Content/css/style.css",
                "~/Content/css/responsive.css",
                "~/Content/css/custom.css"
           ));
        }
    }
}