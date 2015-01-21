using System.Web.Optimization;
using Links;
using Scripts = Links.Scripts;

namespace Links
{
    public static partial class Bundles
    {
        public static partial class Scripts
        {
            public static readonly string bootstrap = "~/bundles/boostrap";
            public static readonly string jquery = "~/bundles/jquery";
            public static readonly string jquery_validate = "~/bundles/jquery-val";
            public static readonly string jquery_typewatch = "~/bundles/jquery-typewatch";
        }

        public static partial class Styles
        {
            public static readonly string bootstrap = "~/css/boostrap";
            public static readonly string flaty = "~/css/flaty";
            public static readonly string bootstrap_theme = "~/css/boostrap-theme";
            public static readonly string font_awesome = "~/css/font-awesome";
            public static readonly string authentication = "~/css/authentication";
        }
    }
}

namespace Warp.WebUI
{
    public partial class Startup
    {
        
        public static void ConfigureBundles(BundleCollection bundles)
        {
            // Bootstrap
            bundles.Add(new ScriptBundle(Bundles.Scripts.bootstrap)
                .Include(Scripts.bootstrap_js));

            bundles.Add(new StyleBundle(Bundles.Styles.bootstrap)
                .Include(Content.bootstrap_css));

            bundles.Add(new StyleBundle(Bundles.Styles.bootstrap_theme)
                .Include(Content.bootstrap_theme_css));

            // Flaty
            bundles.Add(new StyleBundle(Bundles.Styles.flaty)
                .Include(Content.flaty_css)
                .Include(Content.flaty_responsive_css));

            // jQuery
            bundles.Add(new ScriptBundle(Bundles.Scripts.jquery)
                .Include(Scripts.jquery_2_1_1_js));

            // jQuery Validation
            bundles.Add(new ScriptBundle(Bundles.Scripts.jquery_validate)
                .Include(Scripts.jquery_unobtrusive_ajax_js,
                         Scripts.jquery_validate_js,
                         Scripts.jquery_validate_unobtrusive_js,
                         Scripts.jquery_validate_unobtrusive_bootstrap_js));
            // jQuery TypeWatch
            bundles.Add(new ScriptBundle(Bundles.Scripts.jquery_typewatch)
                .Include(Scripts.jquery_typewatch_js));

            // Font Awesome
            bundles.Add(new StyleBundle(Bundles.Styles.font_awesome)
                .Include(Content.font_awesome_css));

            bundles.Add(new StyleBundle(Bundles.Styles.authentication)
                .Include(Content.Styles.Authentication.Login_css));
        }
    }
}