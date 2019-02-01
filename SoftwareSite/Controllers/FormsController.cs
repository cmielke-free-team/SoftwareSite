using System.Web.Mvc;

namespace Emdat.SoftwareSite.Controllers
{
    public class FormsController : SoftwareSiteControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PTPolicy()
        {
            return View();
        }
    }
}