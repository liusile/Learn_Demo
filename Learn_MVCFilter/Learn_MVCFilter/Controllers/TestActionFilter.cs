using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learn_MVCFilter.Controllers
{
    /// <summary>
    /// 调用方法：
    /// 1.放到类中：[TestActionFilter]
    /// 2.放到方法中：[TestActionFilter]
    /// 3.filterConfig中： filters.Add(new TestActionFilter());
    /// </summary>
    public class TestActionFilter:ActionFilterAttribute
    {
        public override  void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("2.OnActionExecuted");
          
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("1.OnActionExecuting");
          
        }

        public override  void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("4.OnResultExecuted");
        
        }

        public override  void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("3.OnResultExecuting");
          
        }
    }
}