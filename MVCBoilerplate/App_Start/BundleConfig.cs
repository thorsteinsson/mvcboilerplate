using System.Web;
using System.Web.Optimization;

namespace MVCBoilerplate
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/knockout-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));
            

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                        "~/Content/bootstrap.css",
                        "~/Content/bootstrap-responsive.css",
                        "~/Content/layout.css"));
        }
    }
}