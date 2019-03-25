using System.Collections.Generic;
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

            if (!string.IsNullOrWhiteSpace(System.IO.Path.GetDirectoryName(fileName)))
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }

            //check the share first
            if (!string.IsNullOrWhiteSpace(DownloadsShare))
            {
                string downloadFilePath = System.IO.Path.Combine(DownloadsShare, fileName);
                if(System.IO.File.Exists(downloadFilePath))
                {
                    string contentType = System.Web.MimeMapping.GetMimeMapping(downloadFilePath);                    
                    if(string.IsNullOrWhiteSpace(contentType))
                    {
                        contentType = "application/octet-stream";
                    }

                    //HACK: If you pass the filename to the File() method it 
                    //always sets Content-Disposition: attachment, which will 
                    //force the browser to present the Save As dialog. So 
                    //instead we are manually setting the Content-Disposition 
                    //header so that the browser will open the file natively if 
                    //it can. For example, if the file is a PDF it will open in 
                    //the browser instead of prompting the user to save the file.
                    this.Response.Headers.Set("Content-Disposition", $"inline; filename={fileName}");
                    return File(downloadFilePath, contentType);
                }
            }

            //otherwise redirect to the legacy downloads folder
            return Redirect(string.Format("{0}/{1}", BASE_URL, fileName));
        }
    }
}