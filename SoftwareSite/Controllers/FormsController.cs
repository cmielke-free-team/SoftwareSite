﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emdat.SoftwareSite.Controllers
{
    public class FormsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PTPolicy()
        {
            return View();
        }
    }
}