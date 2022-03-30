using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
       public string Index()
        {
            return "Abhay From Delhi";
        }

        public string Name()
        {
            return "My name is Abhay";
        }
    }
}