using Emdat.SoftwareSite.DataAccess;
using Emdat.SoftwareSite.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Emdat.SoftwareSite.Controllers
{
    public class InSyncController : SoftwareSiteControllerBase
    {
        private const string APPLICATION_CODE = "InSync";

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

            var additionalLinks = new List<HyperLink>
            {
                new HyperLink
                {
                    NavigateUrl = Url.Action("Index", "Download", new { fileName = "DS-2400_FirmwareUpdate_v1.02_(DSSDS2).zip" }),
                    Text = "Firmware Update for the Olympus DS-2400 Recorder"
                },
                new HyperLink
                {
                    NavigateUrl = Url.Action("Index", "Download", new { fileName = "How to Log in Using MFA for InQuiry, InSync, and Mobile Apps.pdf" }),
                    Text = "How to Login Using MFA"
                },
                new HyperLink
                {
                    NavigateUrl = "http://www.olympusamerica.com/cpg_section/software_results.asp?id=1179&os=w",
                    Text = "Olympus America Software Upgrades"
                }
            };

            // Add a link to the latest MSI build if the latest build has an MSI version
            var latestVersion = versions.FirstOrDefault();
            if (latestVersion != null && !string.IsNullOrWhiteSpace(latestVersion.InstallerFileNameMsi))
            {
                additionalLinks.Add(new HyperLink
                {
                    NavigateUrl = Url.Action("Index", "Download", new { fileName = latestVersion.InstallerFileNameMsi }),
                    Text = string.Format("MSI Installer for IT Administrators: Version {0} MSI", latestVersion.VersionNumber)
                });
            }

            var model = new InSyncViewModel
            {
                AdditionalLinks = additionalLinks.OrderBy(l => l.Text),
                ApplicationCode = APPLICATION_CODE,
                ApplicationName = application.Name,
                SupportedRecorderWarning = "Some older model recorders are not supported by a 64-bit version of Windows. Check with the recorder manufacturer for compatibility.",
                SupportedOperatingSystemWarning = application.SupportedOperatingSystemWarning,
                VersionInformation = new ApplicationVersions
                {
                    ShowVersionHistory = true,
                    Versions = versions
                }
            };

            return View(model);
        }

        public ActionResult VersionHistory()
        {
            var dataContext = new DataContext();
            var application = dataContext.GetApplication(APPLICATION_CODE).FirstOrDefault();
            var model = new ApplicationViewModel
            {
                ApplicationCode = APPLICATION_CODE,
                ApplicationName = application.Name,
                VersionInformation = new ApplicationVersions
                {
                    Versions = from v in dataContext.GetApplicationVersions(APPLICATION_CODE)
                               select new ApplicationVersion
                               {
                                   VersionNumber = v.VersionNumber,
                                   ReleaseNotes = v.ReleaseNotes
                               }
                }
            };

            return View(model);
        }
    }
}