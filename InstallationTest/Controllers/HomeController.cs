using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InstallationTest.Controllers
{
    public class HomeController : Controller2
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC! - cosmetics reworked finished";
            ViewBag.Setting = ConfigurationManager.AppSettings["SomeSetting"];

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
