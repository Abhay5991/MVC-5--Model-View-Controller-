using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemplatedHtmlHelper.Models;

namespace TemplatedHtmlHelper.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee emp = new Employee()
            {
                Id = 1,
                Name = "Abhay",
                Email = "Abhay.kumar817@gmail.com",
                DateOfBirth = DateTime.Now,
                IsOnline = true

            };

            return View(emp);
        }

        public  ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            return View();
        }
    }
}