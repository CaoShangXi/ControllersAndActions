using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControllersAndActions.Controllers;
using System.Web.Mvc;
using System.Collections.Generic;

namespace ControllersAndActions.Tests
{
    [TestClass]
    public class ActionTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //准备-创建控制器
            ExampleController target=new ExampleController();
            //动作-调用动作方法
            ViewResult result=target.Index();
            //断言-检查结果
            Assert.AreEqual("",result.ViewName);
        }
        [TestMethod]
        public void ViewSelectionTest()
        {
            //准备-创建控制器
            ExampleController target=new ExampleController();
            //动作-调用动作方法
            ViewResult result=target.Index();
            //断言-检查结果
            Assert.AreEqual("",result.ViewName);
            Assert.IsInstanceOfType(result.Model,typeof(System.DateTime));
        }

        [TestMethod]
        public void ControllerTest()
        {
            //准备-创建控制器
            ExampleController target = new ExampleController();
            ////动作-调用动作方法
            //ViewResult result = target.Index();
            ////断言-检查结果
            //Assert.AreEqual("Hello",result.ViewBag.Message);
            ////动作-调用动作方法
            //RedirectResult result = target.Redirect();
            ////断言-检查结果
            //Assert.IsTrue(result.Permanent);
            //Assert.AreEqual("/Example/Index", result.Url);
            //RedirectToRouteResult result=target.Redirect();
            //Assert.IsFalse(result.Permanent);
            //Assert.AreEqual("Example",result.RouteValues["controller"]);
            //Assert.AreEqual("Index", result.RouteValues["action"]);
            //Assert.AreEqual("MyID", result.RouteValues["ID"]);
            //Dictionary<string,string> dictionary=new Dictionary<string, string>();
            //dictionary.Add("name","zhangsan");
            //Assert.AreEqual("zhangsan", dictionary["name"]);
            //动作-调用动作方法
            HttpStatusCodeResult result = target.StatusCode();
            //断言-检查结果
            Assert.AreEqual(401,result.StatusCode);
        }
    }
}
