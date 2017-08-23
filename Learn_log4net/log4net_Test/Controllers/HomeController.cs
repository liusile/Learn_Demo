using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace log4net_Test.Controllers
{
    public class HomeController : Controller
    {
        ILog log = LogManager.GetLogger("log");
        
        public ActionResult Index()
        {
            log.Error("bbbb");
            return View();
        }
    }
}