using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoolsAndHeroes.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }

        [Authorize]
        public ActionResult MyCharacter()
        {
            ViewBag.Title = "My Character";
            return View();
        }
    }
}