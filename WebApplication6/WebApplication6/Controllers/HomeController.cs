using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("~/Views/MyView/mynewview.cshtml");
        }

        public ViewResult AboutUs()
        {
            return View();
        }

        public ActionResult WithoutView()
        {
            return View();
        }
        
    }
}