using System.Web.Mvc;

namespace Emdat.SoftwareSite.Controllers
{
    public class DocumentsController : SoftwareSiteControllerBase
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