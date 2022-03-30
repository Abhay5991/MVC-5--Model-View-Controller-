using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StronglyTypeHelper.Models;


namespace StronglyTypeHelper.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee emp = new Employee()
            {
                Address ="this is my address",
                IsEmployee =true,
                Name = "Abhay"

            };

            return View(emp);
        }
        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            return View();
        }
    }
}