using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialViewMVC.Models;

namespace PartialViewMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee ()
                {
                    Id=1,
                    Name = "Abhay",
                    Email = "A@gmail.com",
                    Description="This Is 1 Description"
                },

                new Employee ()
                {
                    Id=2,
                    Name = "2Abhay",
                    Email = "2A@gmail.com",
                    Description="This Is 2 Description"
                },

                new Employee ()
                {
                    Id=3,
                    Name = "3Abhay",
                    Email = "3A@gmail.com",
                    Description="This Is 3 Description"
                },

                new Employee ()
                {
                    Id=4,
                    Name = "4Abhay",
                    Email = "4A@gmail.com",
                    Description="This Is 4 Description"
                },

                new Employee ()
                {
                    Id=5,
                    Name = "5Abhay",
                    Email = "5A@gmail.com",
                    Description="This Is 5 Description"
                },
            };
            return View(emp);
        }
    }
}