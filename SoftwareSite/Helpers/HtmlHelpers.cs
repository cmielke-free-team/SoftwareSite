using System.Text;
using System.Web.Optimization;

namespace System.Web.Mvc.Html
{
    public static class HtmlHelpers
    {
        public static bool IsMinificationEnabled(this HtmlHelper helper)
        {
#if DEBUG
            return false;
#else
			return (helper.ViewContext.RequestContext.HttpContext.Request["scriptdebug"] != "1");
#endif
        }

        private static string CurrentVersion = typeof(HtmlHelpers).Assembly.GetName().Version.ToString();

        public static MvcHtmlString Script(this HtmlHelper helper, string src)
        {
            TagBuilder scriptTagBuilder = new TagBuilder("script");
            scriptTagBuilder.Attributes["type"] = "text/javascript";
            scriptTagBuilder.Attributes["src"] = src;
            return MvcHtmlString.Create(scriptTagBuilder.ToString(TagRenderMode.Normal));
        }

        public static MvcHtmlString StyleSheet(this HtmlHelper helper, string href)
        {
            TagBuilder scriptTagBuilder = new TagBuilder("link");
            scriptTagBuilder.Attributes["href"] = href;
            scriptTagBuilder.Attributes["rel"] = "stylesheet";
            scriptTagBuilder.Attributes["type"] = "text/css";
            return MvcHtmlString.Create(scriptTagBuilder.ToString(TagRenderMode.SelfClosing));
        }

        public static MvcHtmlString IncludedScripts(this HtmlHelper helper)
        {
            StringBuilder jsStringBuilder = new StringBuilder();
            UrlHelper url = new UrlHelper(helper.ViewContext.RequestContext);

            if (helper.IsMinificationEnabled())
            {
                MvcHtmlString scriptTag = helper.Script(BundleTable.Bundles.ResolveBundleUrl("~/Scripts/js", true));
                jsStringBuilder.AppendLine(scriptTag.ToHtmlString());
            }
            else
            {
                foreach (string s in Emdat.SoftwareSite.Helpers.ContentManager.CoreScripts)
                {
                    MvcHtmlString scriptTag = helper.Script(url.Content(string.Format("{0}?v={1}", s, CurrentVersion)));
                    jsStringBuilder.AppendLine(scriptTag.ToHtmlString());
                }
            }
            return MvcHtmlString.Create(jsStringBuilder.ToString());
        }

        public static MvcHtmlString IncludedStyles(this HtmlHelper helper)
        {
            var cssStringBuilder = new StringBuilder();
            var url = new UrlHelper(helper.ViewContext.RequestContext);

            if (helper.IsMinificationEnabled())
            {
                MvcHtmlString stylesheetTag = helper.StyleSheet(BundleTable.Bundles.ResolveBundleUrl("~/Content/css", true));
                cssStringBuilder.AppendLine(stylesheetTag.ToHtmlString());
            }
            else
            {
                foreach (string s in Emdat.SoftwareSite.Helpers.ContentManager.CoreStyleSheets)
                {
                    MvcHtmlString stylesheetTag = helper.StyleSheet(url.Content(string.Format("{0}?v={1}", s, CurrentVersion)));
                    cssStringBuilder.AppendLine(stylesheetTag.ToHtmlString());
                }
            }
            // The following can ad FontAwesome reference from CDN, in case local library (v 5.7) becomes outdated
            //cssStringBuilder.AppendLine(
            //    $@"<link rel='stylesheet' href='https://use.fontawesome.com/releases/v5.6.1/css/all.css' 
            //        integrity='sha384-gfdkjb5BdAXd+lj+gudLWI+BXq4IuLW5IT+brZEZsLFm++aCMlF1V92rMkPaX4PP' crossorigin='anonymous'>");
            return MvcHtmlString.Create(cssStringBuilder.ToString());
        }
    }
}
