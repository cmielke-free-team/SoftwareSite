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
                        NavigateUrl = Url.Action("Index", "Download", new { fileName = "How to Log in Using MFA for InCommand and InScribe.pdf" }),
                        Text = "How to Login Using MFA"
                    },
                    new HyperLink
                    {
                        NavigateUrl = Url.Action("Index", "Download", new { fileName = "eScription One Template Fields User Guide March 2019.pdf" }),
                        Text = "How to use Template Fields and Functions"
                    },
                    new HyperLink
                    {
                        NavigateUrl = Url.Action("Index", "Download", new { fileName = "eScription One InScribe QA Ratings and Feedback Manual June 2019.pdf" }),
                        Text = "QA Ratings and Feedback Manual"
                    },
                    new HyperLink
                    {
                        NavigateUrl = Url.Action("Index", "Download", new { fileName = "eScription One Tips for InScribe 7 Shortcut Customization.pdf" }),
                        Text = "Keyboard Shortcut Customization Guide"
                    }
                },
                ApplicationCode = APPLICATION_CODE,
                ApplicationName = application.Name,
                SupportedOperatingSystemWarning = application.SupportedOperatingSystemWarning,
                TrainingFileLinks = new List<HyperLink>
                {
                    new HyperLink
                    {
                        NavigateUrl = Url.Action("StructuredTraining"),
                        Text = "InScribe ShadowScribe ASR Structured Training"
                    },
                    new HyperLink
                    {
                        NavigateUrl = Url.Action("AsrTraining"),
                        Text = "InScribe ShadowScribe ASR Unstructured Training"
                    },
                    new HyperLink
                    {
                        NavigateUrl = Url.Action("Index", "Download", new { fileName = "InScribeTrainingSetup.exe"}),
                        Text = "InScribe Training Files"
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

        public ActionResult StructuredTraining()
        {
            return View();
        }
    }
}