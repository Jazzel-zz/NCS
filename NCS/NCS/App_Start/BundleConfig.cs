using System.Web;
using System.Web.Optimization;

namespace NCS
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

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/Scripts/js/navscript.js",
                      "~/Scripts/js/jquery.js",
                      "~/Script/js/wow.js",
                      "~/Script/js/bootstrap.min.js",
                      "~/Script/js/jquery.bxslider.min.js",
                      "~/Script/js/jquery.fancybox.js",
                      "~/Script/js/jquery.countTo.js",
                      "~/Script/js/appear.js",
                      "~/Script/js/knob.js",
                      "~/Script/js/owl.js",
                      "~/Script/js/validation.js",
                      "~/Script/js/jquery.mixitup.min.js",
                      "~/Script/js/isotope.js",
                      "~/Script/js/jquery.easing.min.js",
                      "~/Content/assets/jqueryui.1.11.4/jqueryui.js",
                      "~/Content/assets/languageswitcher/jquery.polyglot.language.switcher.js",
                      "~/Content/assets/timepicker/timePicker.js",
                      "~/Content/assets/bootstrapsl.1.12.1/bootstrapselect.js",
                      "~/Content/assets/html5lightbox/html5lightbox.js",
                      "~/Script/plugins/revolution/js/jquery.themepunch.revolution.min.js",
                      "~/Script/plugins/revolution/js/jquery.themepunch.tools.min.js",
                      "~/Script/plugins/revolution/js/extensions/revolution.extension.actions.min.js",
                      "~/Script/plugins/revolution/js/extensions/revolution.extension.carousel.min.js",
                      "~/Script/plugins/revolution/js/extensions/revolution.extension.kenburn.min.js",
                      "~/Script/plugins/revolution/js/extensions/revolution.extension.layeranimation.min.js",
                      "~/Script/plugins/revolution/js/extensions/revolution.extension.migration.min.js",
                      "~/Script/plugins/revolution/js/extensions/revolution.extension.navigation.min.js",
                      "~/Script/plugins/revolution/js/extensions/revolution.extension.parallax.min.js",
                      "~/Script/plugins/revolution/js/extensions/revolution.extension.slideanims.min.js",
                      "~/Script/plugins/revolution/js/extensions/revolution.extension.video.min.js",
                      "~/Script/js/main-slider-script.js",
                      "~/Script/js/custom.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/nav.scss",
                      "~/Content/css/nav.css",
                      "~/Content/css/style.css",
                      "~/Content/css/reponsive.css",
                      "~/Content/css/imp.css",
                      "~/Content/css/bootstrap.css",
                      "~/Content/css/fontawesome.min.css",
                      "~/Content/css/hover.css",
                      "~/Content/css/jquery.bxslider.css",
                      "~/Content/css/owl.css",
                      "~/Content/css/owl.theme.default.css",
                      "~/Content/css/animate.css",
                      "~/Content/css/customanimate.css",
                      "~/Content/css/jquery.bootstraptouchspin.css",
                      "~/Content/css/imagehover.css",
                      "~/Content/css/icomoon.css",
                      "~/Content/css/jquery.fancybox.min.css",
                      "~/Content/css/jquery.mCustomScrollbar.min.css",
                      "~/Content/css/slick.css",
                      "~/Content/fonts/flaticon/flaticon.css",
                      "~/Content/css/flexslider.css",
                      "~/Content/css/bootstrapselect.min.css"
                      ));

            bundles.Add(new StyleBundle("~/Scripts/plugins").Include(
                      "~/Scripts/plugins/revolution/css/settings.css",
                      "~/Scripts/plugins/revolution/css/layers.css",
                      "~/Scripts/plugins/revolution/css/navigation.css"
                ));

            bundles.Add(new StyleBundle("~/Content/assets").Include(
                      "~/Content/assets/pricefilter/nouislider.css",
                      "~/Content/assets/pricefilter/nouislider.pips.css",
                      "~/Content/assets/timepicker/timePicker.css",
                      "~/Content/assets/jqueryui.1.11.4/jqueryui.css",
                      "~/Content/assets/bootstrapsl.1.12.1/bootstrapselect.css",
                      "~/Content/assets/languageswitcher/polyglotlanguageswitcher.css"
                ));


        }
    }
}
