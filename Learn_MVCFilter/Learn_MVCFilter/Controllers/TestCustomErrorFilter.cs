using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Learn_MVCFilter.Controllers
{
    /// <summary>
    /// 通过实现异常接口进行异常处理
    /// </summary>
    public class TestCustomErrorFilter : FilterAttribute,IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            Exception exception = filterContext.Exception;
            //先判断异常是否被其他异常处理了，当有多个异常过滤器时很有必要
            if (filterContext.ExceptionHandled == true)
            {
                return;
            }
            HttpException httpException = new HttpException(null, exception);
            // filterContext.Result = new RedirectResult("~/Home/About");
            filterContext.Result = new RedirectResult("~/Home/About");

            filterContext.ExceptionHandled = true;

        }
    }
}