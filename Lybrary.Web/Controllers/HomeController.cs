using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lybrary.Web.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Hello()
        {
            return Content(string.Format("Hello World"));

        }

        public ActionResult Hi(string id)
        {
            return Content(string.Format("Hi {0}, Good Morning", id));
        }

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
    }
}