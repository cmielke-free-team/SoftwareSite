using System.Linq;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Emdat.SoftwareSite.Controllers
{
    public class NavigationController : SoftwareSiteControllerBase
    {
        [ChildActionOnly]
        public ActionResult Tabs(string currentTab = "Home")
        {
            string[] tabNames = { "Home", "InSync", "Mobile", "InScribe", "InCommand", "InQuiry", "ShadowLink", "ShadowPrint", "Tools", "Documents" };
            var tabs = (from t in tabNames
                        select new MenuItem
                        {
                            Text = t,
                            NavigateUrl = Url.Action("Index", t),
                            Selected = string.Equals(currentTab, t)
                        }).ToList();

            return PartialView(tabs);
        }
    }
}