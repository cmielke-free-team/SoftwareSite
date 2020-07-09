using Emdat.SoftwareSite.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Emdat.SoftwareSite.Controllers
{
    public class MobileController : SoftwareSiteControllerBase
    {
        public ActionResult Index()
        {
            var model = new MobileViewModel
            {
                Description = "Our mobile app is available for iPhone and Android devices. Through the app, a physician is able to obtain his patient schedule, perform dictation, and review transcription. Dictations are sent to the system via the WiFi or Cellular data network for which the device is configured, allowing dictations to get to the medical transcriptionist or language specialist as quickly as possible. The apps can be downloaded to an iPhone, iPod Touch or iPad via the Apple App Store, or to an Android phone or tablet via the Google Play Store. Documentation for installing and using the applications are at the links below:",
                ManualLinks = new List<HyperLink>
                {
                    new HyperLink
                    {
                        NavigateUrl = Url.Action("Index", "Download", new { fileName = "eScription One Mobile Android Manual March 2020.pdf" }),
                        Text = "Android Installation and User Manual"
                    },
                    new HyperLink
                    {
                        NavigateUrl = Url.Action("Index", "Download", new { fileName = "eScription One iOS Manual March 2020.pdf"}),
                        Text = "iPhone Installation and User Manual"
                    },
                    new HyperLink
                    {
                        NavigateUrl = Url.Action("Index", "Download", new { fileName = "How to Log in Using MFA for InQuiry, InSync, and Mobile Apps.pdf" }),
                        Text = "How to Login Using MFA"
                    }
                }
            };

            return View(model);
        }
    }
}