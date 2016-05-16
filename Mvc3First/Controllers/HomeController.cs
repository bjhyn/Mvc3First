using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc3First.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            //return View("About");
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult JiaFa(int valueOne,int valueTwo) {
            int retValue = valueOne + valueTwo;
            return Json(retValue, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Redirect() {

            return this.Redirect("About");
        }
    }
}
