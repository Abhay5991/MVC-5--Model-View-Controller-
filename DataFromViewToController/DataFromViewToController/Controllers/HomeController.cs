using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataFromViewToController.Models;

namespace DataFromViewToController.Controllers
{
    public class HomeController : Controller
    {
       [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string PostusingParameters(string FirstName, string LastName)
        {
            return "From Parameters  - " + FirstName +  "," + LastName;
        }

        [HttpPost]
        public string PostusingRequest()
        {

            string FirstName = Request["FirstName"];
            string LastName = Request["LastName"];
            return "From Request  - " + FirstName + "," + LastName;
        }

        [HttpPost]
        public string PostusingFormCollection(FormCollection form)
        {

            string FirstName = form["FirstName"];
            string LastName = form["LastName"];
            return "From Form Collection  - " + FirstName + "," + LastName;
        }

        [HttpPost]
        public string PostusingBinding(Employee emp)
        {
             return "From Strongly Binding  - " + emp.FirstName + "," + emp.LastName;
        }
    }
}