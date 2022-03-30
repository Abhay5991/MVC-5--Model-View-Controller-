using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TempDataMVC.Models;

namespace TempDataMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [HttpGet]
        public ActionResult Profile1(int Id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProfile2(Student student)
        {
            return View();
        }

        [HttpPut]
        public ActionResult UpdateProfile2(int Id, Student student)
        {
            return View();
        }

        [HttpDelete]
        public ActionResult DeleteProfile1(int Id)
        {
            return View();
        }
    }
}