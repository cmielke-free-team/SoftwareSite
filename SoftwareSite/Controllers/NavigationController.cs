using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Emdat.SoftwareSite.Controllers
{
    public class NavigationController : Controller
    {
        [ChildActionOnly]
        public ActionResult Tabs(string currentTab = "Home")
        {
            string[] tabNames = { "Home", "InSync", "Mobile", "InScribe", "ShadowLink", "ShadowPrint", "Tools", "Forms", "Support" };
            var tabs = (from t in tabNames
                        select new MenuItem
                        {
                            Text = t,
                            //NavigateUrl = $"#{t}",
                            NavigateUrl = Url.Action("Index", t),
                            Selected = string.Equals(currentTab, t)
                        }).ToList();

            return PartialView(tabs);
        }
    }
}