using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using UploadFileImageMVC.Models;

namespace UploadFileImageMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            string path =Server.MapPath( "~/App_Data/File");
            string fileName = Path.GetFileName(emp.File.FileName);

            string fullPath = Path.Combine(path, fileName);

            emp.File.SaveAs(fullPath);

            return View();
        }

        public FileResult Download()
        {
            string path = Server.MapPath("~/App_Data/File");
            string fileName = Path.GetFileName("Loader.jpg");

            string fullPath = Path.Combine(path, fileName);
            return File(fullPath,"image/jpg", "Loader.jpg");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}