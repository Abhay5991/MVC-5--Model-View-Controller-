using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppWithJquery.Models;
using Newtonsoft.Json;

namespace WebAppWithJquery.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetStudent()
        {
            Student std = new Student()
            {
                Id = 1,
                Email = "Abhay@gmail.com",
                Name = "Abhay"
            };
            var json = JsonConvert.SerializeObject(std);

            return Json(json, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult AddStudent(Student student)
        {
            return Json("true", JsonRequestBehavior.AllowGet);
        }
    }
}