using Emdat.SoftwareSite.DataAccess;
using Emdat.SoftwareSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emdat.SoftwareSite.Controllers
{
    public class ToolsController : SoftwareSiteControllerBase
    {
        public ActionResult Index()
        {
            var dataContext = new DataContext();

            var model = new ToolsViewModel
            {
                Tools = from t in dataContext.GetTools()
                        select new Tool
                        {
                            InstallerFileName = t.InstallerFileName,
                            ManualPdfFileName = t.ManualPdfFileName,
                            ManualWordFileName = t.ManualWordFileName,
                            Name = t.Name
                        }
            };

            return View(model);
        }
    }
}