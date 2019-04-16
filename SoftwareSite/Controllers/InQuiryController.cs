using System.Web.Mvc;

namespace Emdat.SoftwareSite.Controllers
{
    public class InQuiryController : SoftwareSiteControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}