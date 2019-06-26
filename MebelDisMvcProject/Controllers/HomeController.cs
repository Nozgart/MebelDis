using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MebelDisMvcProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TestPage()
        {
            ViewBag.Message = "Your Test page. Artorias ";
            ViewBag.TestPage = "Лол кек чебурек я попался на омлет";

            return View();
        }
    }
}