using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Emdat.SoftwareSite.Controllers
{
    public class DownloadController : Controller
    {
        private static string BASE_URL = ConfigurationManager.AppSettings["DownloadsBaseUrl"];

        /// <summary>
        /// Redirect to the downloads folder for now, in the future this could pull from the database or cloud storage or we may point directly to cloud storage and get rid of this controller.
        /// </summary>
        public ActionResult Index(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }

            return Redirect(string.Format("{0}/{1}", BASE_URL, fileName));
        }
    }
}