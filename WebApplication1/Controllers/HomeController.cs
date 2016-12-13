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
            Virtual11 a = new Virtual11();
            a.actionfour();
            Virtual11 cc = new c();
            cc.actionfour();
            cc.actionfour1();
            c u = new c();
            Abstract1 ii =  new b();
            ii.actionthree();
            
            
            return View();
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