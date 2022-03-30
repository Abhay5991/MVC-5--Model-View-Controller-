using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ErrorHandlingMVC.Controllers
{
   
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
           
                throw new Exception("This Is Exception");
            
        }

        public ActionResult About()
        {

            throw new Exception("This Is Exception");

        }
    }
}