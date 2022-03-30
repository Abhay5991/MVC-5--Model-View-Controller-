using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyApp.Models;
using MVCAppWith.Db.DbOperations;

namespace EntityFrameworkMVC.Controllers
{
    public class HomeController : Controller
    {
        EmployeeRepository repository = null;
        public HomeController()
        {
            repository = new EmployeeRepository();
        }

       
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(EmployeeModels models)
        {
            if (ModelState.IsValid)
            {
               int id = repository.AddEmployee(models);
                if (id > 0)
                {
                    ModelState.Clear();

                    ViewBag.Issuccess = "Data Aded";
                }
            }
            return View();
        }

        public ActionResult GetAllRecords()
        {
            var result = repository.GetAllEmployee();
            return View(result);
        }

        public ActionResult Details(int id)
        {
            return View();
        }
    } 
}