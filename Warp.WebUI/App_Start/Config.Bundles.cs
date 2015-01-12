using System.Web.Optimization;

namespace Warp.WebUI
{
    public partial class Startup
    {
        public static void ConfigureBundles(BundleCollection bundles)
        {
            // TODO: Add conditional .min versions for prod version.

            // Bootstrap
            bundles.Add(new ScriptBundle("~/bundles/bootstrap")
                .Include("~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/css/bootstrap")
                .Include("~/Content/bootstrap.css"));

            bundles.Add(new StyleBundle("~/css/bootstrap-theme")
                .Include("~/Content/bootstrap-theme.css"));

            // Flaty
            bundles.Add(new StyleBundle("~/css/flaty")
                .Include("~/Content/flaty.css")
                .Include("~/Content/flaty-responsive.css"));

            // jQuery
            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/jquery-{version}.js"));

            // jQuery Validation
            bundles.Add(new ScriptBundle("~/bundles/jquery-val")
                .Include("~/Scripts/jquery.unobtrusive-ajax.js",
                         "~/Scripts/jquery.validate.js",
                         "~/Scripts/jquery.validate.unobtrusive.js",
                         "~/Scripts/jquery.validate.unobtrusive.bootstrap.js"));
            // jQuery TypeWatch
            bundles.Add(new ScriptBundle("~/bundles/jquery-typewatch")
                .Include("~/Scripts/jquery.typewatch.js"));

            // Font Awesome
            bundles.Add(new StyleBundle("~/css/font-awesome")
                .Include("~/Content/font-awesome.css"));

            bundles.Add(new StyleBundle("~/bundles/authentication")
                .Include("~/Content/Styles/Authentication/Login.css"));
        }
    }
}