using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Learn_ABP.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : Learn_ABPControllerBase
    {
        public ActionResult Index()
        {
            return View();  
        }
	}
}