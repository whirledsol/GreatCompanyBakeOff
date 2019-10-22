﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GreatPerspectaBakeOff.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return RedirectToAction("Instructions");
        }

        public ActionResult Instructions()
        {
            return View();
        }
    }
}