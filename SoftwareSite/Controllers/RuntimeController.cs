using System.Configuration;
using System.Net;
using System.Web.Mvc;

namespace Emdat.SoftwareSite.Controllers
{
    public class RuntimeController : SoftwareSiteControllerBase
    {
        private static string BASE_URL = ConfigurationManager.AppSettings["RuntimesBaseUrl"];

        /// <summary>
        /// Redirect to the runtime folder for now, in the future this could pull from the database or cloud storage 
        /// or we may point directly to cloud storage and get rid of this controller.
        /// </summary>
        public ActionResult Index(string fileName)
        {
            return string.IsNullOrWhiteSpace(fileName) ?
                new HttpStatusCodeResult(HttpStatusCode.NotFound) :
                (ActionResult)Redirect($"{BASE_URL}/{fileName}");
        }
    }
}