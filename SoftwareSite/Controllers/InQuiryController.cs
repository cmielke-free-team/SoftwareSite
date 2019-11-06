using Emdat.SoftwareSite.DataAccess;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Emdat.SoftwareSite.Controllers
{
    [RoutePrefix("InQuiry")]
    public class InQuiryController : SoftwareSiteControllerBase
    {
        private const string PRINT_AGENT_APP_CODE = "PrintAgent";

        public ActionResult Index()
        {
            return View();
        }

        [Route("PrintAgent/Download")]
        public ActionResult DownloadPrintAgent()
        {
            var data = new DataContext();
            var versions = data.GetLatestApplicationVersions(PRINT_AGENT_APP_CODE);
            if (!versions.Any())
            {
                throw new Exception("Unable to find print agent versions.");
            }

            var latest = versions
                .OrderByDescending(v => Version.Parse(v.VersionNumber))
                .First();

            return RedirectToRoute(new
            {
                controller = "Download",
                action = "Index",
                fileName = latest.InstallerFileName
            });
        }

        [Route("PrintAgent/Versions")]
        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult GetPrintAgentVersions(bool? latestOnly)
        {
            var data = new DataContext();
            var versions = data.GetLatestApplicationVersions(PRINT_AGENT_APP_CODE);
            if (!versions.Any())
            {
                return HttpNotFound();
            }

            var result = versions
                .OrderByDescending(v => Version.Parse(v.VersionNumber))
                .Select(v => v.VersionNumber)
                .ToList();
            

            if (latestOnly.GetValueOrDefault() && result.Count > 1)
            {
                result.RemoveRange(1, result.Count - 1);
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}