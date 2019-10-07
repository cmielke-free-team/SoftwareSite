using Emdat.SoftwareSite.DataAccess;
using Emdat.SoftwareSite.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Emdat.SoftwareSite.Controllers
{
    public class ShadowPrintController : SoftwareSiteControllerBase
    {
        private const string APPLICATION_CODE = "ShadowPrint";

        public ActionResult Index()
        {
            var dataContext = new DataContext();

            var application = dataContext.GetApplication(APPLICATION_CODE).FirstOrDefault();
            var versions = from v in dataContext.GetLatestApplicationVersions(APPLICATION_CODE)
                           select new ApplicationVersion
                           {
                               InstallerFileName = GetInstallerFileName(v),
                               InstallerFileNameMsi = GetInstallerFileNameMsi(v),
                               MajorVersionNumber = v.MajorVersionNumber,
                               ManualPdfFileName = v.ManualPdfFileName,
                               ManualWordFileName = v.ManualWordFileName,
                               VersionNumber = v.VersionNumber
                           };

            var model = new ApplicationViewModel
            {
                ApplicationCode = APPLICATION_CODE,
                ApplicationName = application.Name,
                SupportedOperatingSystemWarning = application.SupportedOperatingSystemWarning,
                VersionInformation = new ApplicationVersions
                {
                    ShowVersionHistory = false,
                    Versions = versions
                }
            };

            return View(model);
        }

        public ActionResult Download()
        {
            var data = new DataContext();
            var versions = data.GetLatestApplicationVersions(APPLICATION_CODE);
            if (!versions.Any())
            {
                throw new Exception("Unable to find ShadowPrint versions.");
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
    }
}