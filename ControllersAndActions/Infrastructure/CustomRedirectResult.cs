using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersAndActions.Infrastructure
{
    /// <summary>
    /// 自定义动作结果
    /// </summary>
    public class CustomRedirectResult : ActionResult
    {
        public string Url { get; set; }
        /// <summary>
        /// MVC框架对动作结果的处理过程应是：从动作方法返回ActionResult对象，然后调用该对象的ExecuteResult方法，该方法负责处理Response对象，并生成所期望的输出
        /// </summary>
        /// <param name="context"></param>
        public override void ExecuteResult(ControllerContext context)
        {
            string fullUrl=UrlHelper.GenerateContentUrl(Url, context.HttpContext);
            context.HttpContext.Response.Redirect(fullUrl);
        }
    }
}