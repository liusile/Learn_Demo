using System.Web;
using System.Web.Mvc;
using Learn_MVCFilter.Controllers;

namespace Learn_MVCFilter
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // filters.Add(new HandleErrorAttribute());
            // filters.Add(new TestActionFilter());
            //filters.Add(new TestHandlerErrorFilter());
        }
    }
}
