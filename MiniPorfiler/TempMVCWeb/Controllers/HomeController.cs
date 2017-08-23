using DoMain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempMVCWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var context = new MVCContext();
            context.Student.Add(new Student
            {
                Name = "lusi"
            });
            context.SaveChanges();
            var student = context.Student.FirstOrDefault();
            ViewBag.Name = student.Name;
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