using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TraditionalRouting.Models;

namespace TraditionalRouting.Controllers
{
    [RoutePrefix("Students")]
    public class StudentsController : Controller
    {
        [Route("")]

        public ActionResult GetAllStudent()
        {
            var students = Student();
            return View(students);
        }

        [Route("{id:int:min(5)")]

        public ActionResult GetStudent(int id  )
        {
            var student = Student().FirstOrDefault(x => x.Id == id);
            return View(student);
        }
        [Route("{id}/Address")]
        public ActionResult GetStudentAddress(int id)
        {
            var studentAdress = Student().Where(x=> x.Id == id).Select(x=>x.Address).FirstOrDefault();
            return View(studentAdress);
        }

        [Route("id")]
        public string Mystring(string id)
        {
            return id;
        }

        [Route("~/About-Us")]
        [Route("~/AboutUs")]
        public string AboutUs(string id)
        {
            return "This is about us";
        }
        private List<Students> Student()
        {
            return new List<Students>()
            {
                new Students()
                {
                    Id = 1,
                    Name = "1- Student",
                    Class="First",
                    Address = new Address ()
                    {
                        Address1= "This is Student 1 Address",
                        City = "Student 1 City",
                        HomeNumber = "Student 1"
                    }
                },

            new Students()
            {
                Id = 2,
                Name = "2- Student",
                Class = "Two",
                Address = new Address()
                {
                    Address1 = "This is Student 2 Address",
                    City = "Student 2 City",
                    HomeNumber = "Student 2"
                }
            },

             new Students()
                {
                    Id = 3,
                    Name = "3- Student",
                    Class="Three",
                    Address = new Address ()
                    {
                        Address1= "This is Student 3 Address",
                        City = "Student 3 City",
                        HomeNumber = "Student 3"
                    }
                },
              new Students()
                {
                    Id = 4,
                    Name = "4- Student",
                    Class="Four",
                    Address = new Address ()
                    {
                        Address1= "This is Student 4 Address",
                        City = "Student 4 City",
                        HomeNumber = "Student 4"
                    }
                },
               new Students()
                {
                    Id = 5,
                    Name = "5- Student",
                    Class="Five",
                    Address = new Address ()
                    {
                        Address1= "This is Student 5 Address",
                        City = "Student 5 City",
                        HomeNumber = "Student 5"
                    }
                },
                new Students()
                {
                    Id = 6,
                    Name = "6- Student",
                    Class="Six",
                    Address = new Address ()
                    {
                        Address1= "This is Student 6 Address",
                        City = "Student 6 City",
                        HomeNumber = "Student 6"
                    }
                },
        };
        }
    }
}