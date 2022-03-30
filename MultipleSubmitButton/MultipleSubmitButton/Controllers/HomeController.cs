using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultipleSubmitButton.Models;

namespace MultipleSubmitButton.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Employee emp,string create,string edit)
        {
            if (create=="Create")
            {
                //
            }
            else if (edit=="Edit")
            {
                //
            }
            return View();
        }
    }
}