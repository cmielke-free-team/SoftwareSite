using System.Web.Mvc;

namespace Emdat.SoftwareSite.Controllers
{
    public class InCommandController : SoftwareSiteControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}