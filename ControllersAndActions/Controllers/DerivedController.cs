using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControllersAndActions.Infrastructure;

namespace ControllersAndActions.Controllers
{
    public class DerivedController : Controller
    {
        // GET: Derived
        public ActionResult Index()
        {
            ViewBag.Message = "Hello from the DerivedController Index method";
            ViewBag.Date = "2020-03-22";
            return View("MyView");
        }
        public ActionResult ProduceOutput()
        {
            //if (Server.MachineName=="TINY")
            //{
            //    //Response.Redirect("/Basic/Index");//重定向到/Basic/Index
            //    return new CustomRedirectResult { Url="/Basic/Index"};
            //}
            //else
            //{
            //    Response.Write("controller：Derived，Action：ProduceOutput");
            //    return null;
            //}
            //return new RedirectResult("/Basic/Index");
            return Redirect("/Basic/Index");
        }
    }
}