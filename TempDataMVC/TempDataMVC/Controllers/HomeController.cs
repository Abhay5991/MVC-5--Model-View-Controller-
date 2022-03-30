using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempDataMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            TempData["MyKey"] = "DAta from Index Method"; 
            return View();
        }

        public ActionResult Index2()
        {
            Session.Abandon();
            ViewBag.MyKey = TempData.Peek("MyKey");
            
            return View();
        }

        public ActionResult Index3()
        {
            ViewBag.MyKey = TempData["MyKey"];
            return View();
        }
    }
}