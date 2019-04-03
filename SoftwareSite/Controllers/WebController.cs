using System.Web.Mvc;

namespace Emdat.SoftwareSite.Controllers
{
    public class WebController : SoftwareSiteControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}