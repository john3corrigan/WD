using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace whistlingdixiepodcast.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Getting to know us.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "We have email.";

            return View();
        }
    }
}