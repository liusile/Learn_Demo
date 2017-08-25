using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learn_MVCFilter.Controllers
{
   // [TestActionFilter]
    public class HomeController : Controller
    {
        // [TestActionFilter]
        //[TestHandlerErrorFilter(View = "~/Views/Home/About.cshtml")]
        // [TestHandlerErrorFilter]
       // [TestCustomErrorFilter]
        public ActionResult Index()
        {
            
            int.Parse("ppp");
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