using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultipleModelOnSingleView.Models;
using System.Dynamic;

namespace MultipleModelOnSingleView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            

            //ViewBag["employees"] = employees;
            //ViewBag["students"] = students;


            //ViewBag.employees = employees;
            //ViewBag.students = students;

            //var model = new Tuple<List<Employee>, List<Student>>(employees, students);


            //dynamic model = new ExpandoObject();
            //model.employees = employees;
            //model.students = students;

            return View();
        }

        public PartialViewResult Employee()
        {
            
            var employees = GetEmployes();
            return PartialView("_EmployeeData", employees);
        }

        public PartialViewResult Student()
        {
            var students = GetStudents();
           
            return PartialView("_StudentData", students);
        }

        private List<Employee> GetEmployes()
        {
            return new List<Employee>()
            {
                new Employee (){Id=1,Name="Abhay",Email="Abhay@gmail.com"},
                new Employee (){Id=2,Name="Kumar",Email="Kumar@gmail.com"},
                new Employee (){Id=3,Name="Aman",Email="Aman@gmail.com"}
            };
        }

        private List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student (){Id=1,Name="Ajay",Email="Ajay@gmail.com"},
                new Student (){Id=2,Name="Gaurav",Email="Gaurav@gmail.com"},
                new Student (){Id=3,Name="Saurav",Email="Saurav@gmail.com"}
            };
        }
    }
}