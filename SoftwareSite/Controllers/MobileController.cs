using Emdat.SoftwareSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Emdat.SoftwareSite.Controllers
{
    public class MobileController : Controller
    {
        public ActionResult Index()
        {
            // TODO: If Canada hide any mention of Android
            var model = new MobileViewModel
            {
                Description = "Our mobile app is available for iPhone and Android devices. Through the app, a physician is able to obtain his patient schedule, perform dictation, and review transcription. Dictations are sent to the system via the WiFi or Cellular data network for which the device is configured, allowing dictations to get to the medical transcriptionist or language specialist as quickly as possible. The apps can be downloaded to an iPhone, iPod Touch or iPad via the Apple App Store, or to an Android phone or tablet via the Android Marketplace. Documentation for installing and using the applications are at the links below:",
                ManualLinks = new List<HyperLink>
                {
                    new HyperLink
                    {
                        NavigateUrl = Url.Action("Index", "Download", new { fileName = "Emdat%20Mobile%20iOS%20Manual%202014%20Final.pdf"}),
                        Text = "iPhone Installation and User Manual (PDF)"
                    },
                    new HyperLink
                    {
                        NavigateUrl = Url.Action("Index", "Download", new { fileName = "Emdat%20Mobile%20iOS%20Manual%202014%20Final.docx"}),
                        Text = "iPhone Installation and User Manual (DOC)"
                    },
                    new HyperLink
                    {
                        NavigateUrl = Url.Action("Index", "Download", new { fileName = "Emdat%20Mobile%20Android%20Manual%202.4.0.pdf"}),
                        Text = "Android Installation and User Manual (PDF)"
                    },
                    new HyperLink
                    {
                        NavigateUrl = Url.Action("Index", "Download", new { fileName = "Emdat%20Mobile%20Android%20Manual%202.4.0.docx"}),
                        Text = "Android Installation and User Manual (DOC)"
                    }
                }
            };

            return View(model);
        }
    }
}