using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        // GET: Example
        //public ViewResult Index()
        //{
        //    return View("HomePage");
        //}

        public ViewResult Index()
        {
            DateTime date=DateTime.Now;
            ViewBag.Message = "Hello";
            ViewBag.Date = date;
            return View(date);
        }

        //public RedirectResult Redirect()
        //{
        //    return RedirectPermanent("/Example/Index");
        //}

        public RedirectToRouteResult Redirect()
        {
            return RedirectToRoute(new { controller = "Example", action = "Index", ID = "MyID" });
        }

        /// <summary>
        /// 发送HTTP特定代码
        /// </summary>
        /// <returns></returns>
        public HttpStatusCodeResult StatusCode()
        {
            //return new HttpStatusCodeResult(404,"URL cannot besericed");//返回404代码
            //return HttpNotFound();//返回404代码
            return new HttpUnauthorizedResult();//返回401代码
        }
    }
}