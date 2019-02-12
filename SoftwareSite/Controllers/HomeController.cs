using Emdat.SoftwareSite.Models;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Web.Mvc;

namespace Emdat.SoftwareSite.Controllers
{
    public class HomeController : SoftwareSiteControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Notification()
        {
            return new EmptyResult();
        }

        public ActionResult Header()
        {
            return View();
        }

        public ActionResult Footer()
        {
            var model = new FooterViewModel
            {
                CopyrightDate = string.Format("2001-{0}", DateTime.Now.Year),
                ServerName = Environment.MachineName.ToUpperInvariant()
            };
            return View(model);
        }
        /// <summary>
        /// Primitive page that F5 uses to verify corresponding app pool is still up and running
        /// </summary>
        /// <returns></returns>
        public ActionResult HealthCheck()
        {
            string appPoolName = Environment.GetEnvironmentVariable("APP_POOL_ID", EnvironmentVariableTarget.Process);
            TimeSpan uptime = DateTime.Now - Process.GetCurrentProcess().StartTime;
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
            return Content($@"The <strong>{appPoolName}</strong> application pool has been up and running on 
                        <strong>{Environment.MachineName}</strong> for <strong>{uptime.ToString(@"hh\:mm\:ss")}</strong>.<br><br>
                        Build: {fileVersionInfo.FileVersion}", "text/html");
        }
    }
}