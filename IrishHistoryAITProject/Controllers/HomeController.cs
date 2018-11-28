using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IrishHistoryAITProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About the Irish War of Independence";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us For More Information!";

            return View();
        }
    }
}