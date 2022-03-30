using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterOutputCache.Controllers
{

    [OutputCache(Duration = 10, Location =System.Web.UI.OutputCacheLocation.Client)]
    public class HomeController : Controller
    {
        public ActionResult GetDate()
        {
            return View();
        }

        public int GetTate()
        {
            return DateTime.Now.Day;
        }
    }
}