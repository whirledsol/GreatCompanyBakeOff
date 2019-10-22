using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace GreatPerspectaBakeOff.Controllers
{
    public class RecipesController : Controller
    {
        public RecipesController()
        {
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Detail(int id)
        {
            return View();
        }
    }
}