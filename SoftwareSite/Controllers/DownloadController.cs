using System.Configuration;
using System.Net;
using System.Web.Mvc;

namespace Emdat.SoftwareSite.Controllers
{
    public class DownloadController : SoftwareSiteControllerBase
    {
        private static string BASE_URL = ConfigurationManager.AppSettings["DownloadsBaseUrl"];
        private static string DownloadsShare = ConfigurationManager.AppSettings["DownloadsShare"];

        /// <summary>
        /// Redirect to the download folder for now, in the future this could pull from the database or cloud storage or we may point directly to cloud storage and get rid of this controller.
        /// </summary>
        public ActionResult Index(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }
            
            //check the share first
            if(!string.IsNullOrWhiteSpace(DownloadsShare))
            {                
                string downloadFilePath = System.IO.Path.Combine(DownloadsShare, fileName);
                if(System.IO.File.Exists(downloadFilePath))
                {                    
                    return File(downloadFilePath, "application/octet-stream", fileName);
                }
            }

            //otherwise redirect to the legacy downloads folder
            return Redirect(string.Format("{0}/{1}", BASE_URL, fileName));
        }
    }
}