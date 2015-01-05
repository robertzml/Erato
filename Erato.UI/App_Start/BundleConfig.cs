using System.Web;
using System.Web.Optimization;

namespace Erato.UI
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/core").Include(
                        "~/assets/global/plugins/jquery-ui/jquery-ui-1.10.3.custom.min.js",
                        "~/assets/global/plugins/bootstrap/js/bootstrap.min.js",
                        "~/assets/global/plugins/bootstrap-hover-dropdown/bootstrap-hover-dropdown.min.js",
                        "~/assets/global/plugins/jquery-slimscroll/jquery.slimscroll.min.js",
                        "~/assets/global/plugins/jquery.blockui.min.js",
                        "~/assets/global/plugins/jquery.cokie.min.js",
                        "~/assets/global/plugins/uniform/jquery.uniform.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                        "~/assets/global/plugins/datatables/media/js/jquery.dataTables.min.js",
                        "~/assets/global/plugins/datatables/extensions/TableTools/js/dataTables.tableTools.min.js",
                        "~/assets/global/plugins/datatables/extensions/Scroller/js/dataTables.scroller.min.js",
                        "~/assets/global/plugins/datatables/plugins/bootstrap/dataTables.bootstrap.js"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));



            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css"));
        }
    }
}
