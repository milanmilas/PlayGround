using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELMAHLogging.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult AboutExecute()
        {
            throw new Exception("Something Wrong");
        }

        public ActionResult Trouble()
        {
            return View("Error2");
        }
    }
}
