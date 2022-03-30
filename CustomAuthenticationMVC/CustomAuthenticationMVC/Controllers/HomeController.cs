using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomAuthenticationMVC.Filter;

namespace CustomAuthenticationMVC.Controllers
{
    public class HomeController : Controller
    {
        
       // [AbhayAuthentication]
        //[AbhayAction]
        [AbhayException]
        public ActionResult Index()
        {
            throw new NotImplementedException();
        }
    }
}