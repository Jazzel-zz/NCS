using System.Web;
using System.Web.Optimization;

namespace NCS
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
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
                     "~/Content/assets/dash/pricefilter/nouislider.css",
                     "~/Content/assets/dash/pricefilter/nouislider.pips.css",
                     "~/Content/assets/dash/timepicker/timePicker.css",
                     "~/Content/assets/dash/jqueryui.1.11.4/jqueryui.css",
                     "~/Content/assets/dash/bootstrapsl.1.12.1/bootstrapselect.css",
                     "~/Content/assets/dash/languageswitcher/polyglotlanguageswitcher.css"
                               ));

            bundles.Add(new StyleBundle("~/Content/assets/dash").Include(
                      "~/Content/assets/dash/libs/datatables/dataTables.bootstrap4.css",
                      "~/Content/assets/dash/libs/datatables/responsive.bootstrap4.css",
                      "~/Content/assets/dash/libs/datatables/buttons.bootstrap4.css",
                      "~/Content/assets/dash/libs/datatables/select.bootstrap4.css",
                      "~/Content/assets/dash/css/bootstrap.min.css",
                      "~/Content/assets/dash/css/icons.min.css",
                      "~/Content/assets/dash/css/app.min.css"

                     
                                ));

            bundles.Add(new ScriptBundle("~/Scripts/dash").Include(
                  "~/Scripts/assets/dash/js/vendor.min.js",
                    "~/Scripts/assets/dash/libs/jquery-knob/jquery.knob.min.js",
                    "~/Scripts/assets/dash/libs/peity/jquery.peity.min.js",
                    "~/Scripts/assets/dash/libs/jquery-sparkline/jquery.sparkline.min.js",
                    "~/Scripts/assets/dash/js/pages/dashboard-1.init.js",
                    "~/Scripts/assets/dash/js/app.min.js",
                    "~/Scripts/assets/dash/libs/datatables/jquery.dataTables.min.js",
                    "~/Scripts/assets/dash/libs/datatables/dataTables.bootstrap4.js",
                    "~/Scripts/assets/dash/libs/datatables/dataTables.responsive.min.js",
                    "~/Scripts/assets/dash/libs/datatables/responsive.bootstrap4.min.js",
                    "~/Scripts/assets/dash/libs/datatables/dataTables.buttons.min.js",
                    "~/Scripts/assets/dash/libs/datatables/buttons.bootstrap4.min.js",
                    "~/Scripts/assets/dash/libs/datatables/buttons.html5.min.js",
                    "~/Scripts/assets/dash/libs/datatables/buttons.flash.min.js",
                    "~/Scripts/assets/dash/libs/datatables/buttons.print.min.js",
                    "~/Scripts/assets/dash/libs/datatables/dataTables.keyTable.min.js",
                    "~/Scripts/assets/dash/libs/datatables/dataTables.select.min.js",
                    "~/Scripts/assets/dash/libs/pdfmake/pdfmake.min.js",
                    "~/Scripts/assets/dash/libs/pdfmake/vfs_fonts.js",
                    "~/Scripts/assets/dash/js/pages/datatables.init.js"


                              ));


        }
    }
}
