using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ControllersAndActions.Controllers
{
    /// <summary>
    /// 自定义控制器
    /// </summary>
    public class BasicController : IController
    {
        /// <summary>
        /// 请求路径到/Basic/Index，该方法会被自动执行
        /// </summary>
        /// <param name="requestContext"></param>
        public void Execute(RequestContext requestContext)
        {
            string controller=(string)requestContext.RouteData.Values["controller"];//获取片段变量为controller的值
            string action = (string)requestContext.RouteData.Values["action"];//获取片段变量为action的值
            if (action.ToLower()=="redirect")
            {
                requestContext.HttpContext.Response.Redirect("/Derived/Index");//重定向到/Derived/Index
            }
            else
            {
            //输出响应信息给浏览器端
            requestContext.HttpContext.Response.Write(string.Format("controller：{0}，action：{1}", controller, action));
            }
        }
    }
}