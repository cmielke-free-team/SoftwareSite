using System.Collections.Generic;

namespace Emdat.SoftwareSite.Helpers
{
    public static class ContentManager
    {
        public static IEnumerable<string> CoreScripts
        {
            get
            {
                return _coreScripts;
            }
        }
        private static readonly string[] _coreScripts = new[]
        {
            "~/Scripts/jquery-3.3.1.js",
            "~/Scripts/jquery-ui-1.12.1.js"
        };

        public static IEnumerable<string> CoreStyleSheets
        {
            get
            {
                return _coreStyleSheets;
            }
        }
        private static readonly string[] _coreStyleSheets = new[]
        {
            "~/Content/style.css",
            "~/Content/user-menu.css",
            "~/Content/jquery-ui-1.8.6.custom.css",
            "~/Content/fontawesome-all.css"
		};

    }
}