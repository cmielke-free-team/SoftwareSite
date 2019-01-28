using Emdat.SoftwareSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emdat.SoftwareSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
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
    }
}