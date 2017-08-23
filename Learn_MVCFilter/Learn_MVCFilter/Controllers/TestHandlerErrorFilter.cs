using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learn_MVCFilter.Controllers
{
    /// <summary>
    /// 1.默认调用~/Shared/Error.cshtml视图
    /// </summary>
    public class TestHandlerErrorFilter:HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            
            filterContext.HttpContext.Response.Write(filterContext.Exception.Message);
            filterContext.Result=new RedirectResult("~/Home/About");
           // filterContext.Result = new RedirectResult("~/LLL.html");
            filterContext.ExceptionHandled = true;//表示异常已处理，其他异常不在处理
            base.OnException(filterContext);
        }
    }
}
