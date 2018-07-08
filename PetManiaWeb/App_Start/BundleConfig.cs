using System.Web;
using System.Web.Optimization;

namespace PetManiaWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.3.1.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                      "~/Scripts/knockout-3.4.2.js",
                      "~/Scripts/dataTables/datatables.min.js",
                      "~/Scripts/dataTables/jquery.dataTables.min.js",
                      "~/Scripts/dataTables/dataTables.bootstrap.min.js",
                      "~/Scripts/dataTables/dataTables.bootstrap4.min.js",
                      "~/Scripts/dataTables/JavaScript.js",
                      "~/Scripts/dataTables/pdfmake.min.js",
                      "~/Scripts/dataTables/vfs_fonts.js",
                      "~/Scripts/dataTables/buttons.html5.js",
                      "~/Scripts/dataTables/datatables.fnReloadAjax.js",
                      "~/Scripts/dataTables/jquery.dataTables.plugins.js",
                      "~/Scripts/dataTables/dataTables.tableTools.js",
                      "~/Scripts/dataTables/cog.js",
                      "~/Scripts/dataTables/cog.utils.js",
                      "~/Scripts/dataTables/knockount.binding.dataTable.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/dataTables.bootsstrap.min.css",
                      "~/Content/Style/carousel.css",
                      "~/Content/Style/style-home.css",
                      "~/Content/Style/style-login.css",
                      "~/Content/Style/style-cadastro.css",
                      "~/Content/style.css"));
        }
    }
}
