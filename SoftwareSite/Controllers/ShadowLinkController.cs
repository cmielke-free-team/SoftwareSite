using Emdat.SoftwareSite.DataAccess;
using Emdat.SoftwareSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emdat.SoftwareSite.Controllers
{
    public class ShadowLinkController : SoftwareSiteControllerBase
    {
        private const string APPLICATION_CODE = "ShadowLink";

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
    }
}