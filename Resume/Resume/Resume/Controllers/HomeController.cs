using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Resume.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Ahanab Shakil, Welcome to my CV";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Me";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "My Contact Details.";

            return View();
        }

        public ActionResult Education()
        {
            ViewBag.Message = "My Educational Details.";

            return View();
        }

        public ActionResult Objective()
        {
            ViewBag.Message = "My Objectives";

            return View();
        }



    }
}