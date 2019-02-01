using Emdat.SoftwareSite.DataAccess;
using Emdat.SoftwareSite.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Emdat.SoftwareSite.Controllers
{
    public class InScribeController : SoftwareSiteControllerBase
    {
        private const string APPLICATION_CODE = "InScribe";

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

            var model = new InScribeViewModel
            {
                AdditionalLinks = new List<HyperLink>
                {
                    new HyperLink
                    {
                        NavigateUrl = Url.Action("Index", "Download", new { fileName = "Intro%20to%20InScribe%206_v4.pdf"}),
                        Text = "An Introduction to InScribe 6 (PDF)"
                    },
                    new HyperLink
                    {
                        NavigateUrl = Url.Action("Index", "Download", new { fileName = "Intro%20to%20InScribe%206_v4.docx"}),
                        Text = "An Introduction to InScribe 6 (DOC)"
                    },
                    new HyperLink
                    {
                        NavigateUrl = Url.Action("Index", "Download", new { fileName = "Template%20Fields%20Use%20Guide%2020170608.1.docx"}),
                        Text = "How to use Template Fields and Functions"
                    },
                    new HyperLink
                    {
                        NavigateUrl = Url.Action("SpellCheckFaq"),
                        Text = "Spell Checker FAQ"
                    },
                },
                ApplicationCode = APPLICATION_CODE,
                ApplicationName = application.Name,
                SupportedOperatingSystemWarning = application.SupportedOperatingSystemWarning,
                TrainingFileLinks = new List<HyperLink>
                {
                    new HyperLink
                    {
                        NavigateUrl = Url.Action("Index", "Download", new { fileName = "InScribe6TrainingSetup.exe"}),
                        Text = "InScribe 6 Training Files"
                    },
                    new HyperLink
                    {
                        NavigateUrl = Url.Action("AsrTraining"),
                        Text = "InScribe ShadowScribe ASR Training"
                    }
                },
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

        public ActionResult AsrTraining()
        {
            return View();
        }

        public ActionResult SpellCheckFaq()
        {
            return View();
        }
    }
}