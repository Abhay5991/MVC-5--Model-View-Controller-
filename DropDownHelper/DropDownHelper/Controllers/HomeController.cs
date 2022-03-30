using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DropDownHelper.Models;

namespace DropDownHelper.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        
        public ActionResult Test()
        {
            
            //var list = new List<string>() { "India", "China", "America", "Japan" };
            

            var country = new List<Country>()
            {
                new Country() {Id= 1,Text="India" },
                 new Country() {Id= 2,Text="China" },
                  new Country() {Id= 3,Text="America" },
                   new Country() {Id= 4,Text="Japan" }
            };

            ViewBag.list = country;

            Employee emp = new Employee()
            {
                Country = 1
            };

            return View(emp);
        }

        [HttpPost]
        public ActionResult Test(Employee emp)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Test");
            }
            var country = new List<Country>()
            {
                new Country() {Id= 1,Text="India" },
                 new Country() {Id= 2,Text="China" },
                  new Country() {Id= 3,Text="America" },
                   new Country() {Id= 4,Text="Japan" }
            };

            ViewBag.list = country;
            return View();
            //var list = new List<string>() {"India" ,"China", "America","Japan" };
            //ViewBag.list = list;
            
        }

        class Country
        {
            public int Id { get; set; }

            public string Text { get; set; }
        }
    }
}