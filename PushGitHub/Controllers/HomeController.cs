using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PushGitHub.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Welcome to SkillTree";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "https://skilltree.my";
            ViewBag.Message = "02-5568-6577#101";

            return View();
        }
    }
}