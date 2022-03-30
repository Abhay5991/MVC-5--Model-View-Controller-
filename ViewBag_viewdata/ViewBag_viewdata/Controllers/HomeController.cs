using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBag_viewdata.Models;

namespace ViewBag_viewdata.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.MyCustomeProperty = "Abhay";

            ViewBag.MyList = new List<string>() { "Abhay", "Kumar", " Aman", "Sunny" };

            List <Employee> empList = new List <Employee>()
            {
                new Employee() { Email= "A@gmail.com"  ,  Id =1 , Name = "Kumar"},
                new Employee() {    Email = "b@gmail.com"  ,  Id = 2 ,    Name = "Kumar1"},
                new Employee() {   Email = "c@gmail.com"  ,  Id = 3 ,    Name = "Kumar2"},
                new Employee() { Email = "d@gmail.com"  ,  Id = 4 ,    Name = "Kumar3"}
        };

            ViewBag.MyempList = empList;
            return View();
        }

        public ActionResult Demo()
        {
            ViewData["MyKey"] = " This is Value For Mykeys";

            ViewData["MyList"] = new List<string>() { "Abhay", "Kumar", " Aman", "Sunny" };
            return View();
        }
    }
}