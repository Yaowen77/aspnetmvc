using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ViewBag.Test = "test";
            //ViewData["A"] = "A";
            //var test = new Models.Class1 { test = "aa" };//var 資料型態為Models.Class1
            List<Models.Class1> testList = new List<Models.Class1>
            {
                new Models.Class1 { test = "aa" },
                new Models.Class1 {test = "bb" },
                new Models.Class1 { test = "cc" },
                new Models.Class1 { test = "dd" }
            };

            return View(testList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}