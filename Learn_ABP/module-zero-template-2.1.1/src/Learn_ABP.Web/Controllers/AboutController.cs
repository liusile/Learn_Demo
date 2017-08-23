using System.Web.Mvc;

namespace Learn_ABP.Web.Controllers
{
    public class AboutController : Learn_ABPControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}