using System.Web.Optimization;

namespace Emdat.SoftwareSite
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundleCollection)
        {
            var coreJsBundle = new Bundle("~/Scripts/js");
            foreach (var script in Helpers.ContentManager.CoreScripts)
            {
                coreJsBundle.Include(script);
            }
            bundleCollection.Add(coreJsBundle);

            var coreCssBundle = new Bundle("~/Content/css");
            foreach (var stylesheet in Helpers.ContentManager.CoreStyleSheets)
            {
                coreCssBundle.Include(stylesheet);
            }
            bundleCollection.Add(coreCssBundle);
        }
    }
}
