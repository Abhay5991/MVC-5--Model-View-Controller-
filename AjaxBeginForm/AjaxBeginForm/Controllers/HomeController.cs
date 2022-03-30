using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxBeginForm.Models;
using Newtonsoft.Json;

namespace AjaxBeginForm.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Index(Emplopyee model)
        {
            return Json("true",JsonRequestBehavior.AllowGet);
        }

        public ActionResult List()
        {
            return View();
        }

        public JsonResult Countries()
        {
            List<string> countries = new List<string>()
            {
                 "Albania"
                ,"Algeria"
                ,"Andorra"
                ,"Angola"
                ,"Antigua"  
                ,"Barbuda"
                ,"Argentina"
                ,"Armenia"
                ,"Australia"
                ,"Austria"
                ,"Azerbaijan" 
                ,"Bahamas"      

            };
            var json = JsonConvert.SerializeObject(countries);

            return Json(json , JsonRequestBehavior.AllowGet);
        }

        public JsonResult States()
        {
            List<string> states = new List<string>()
            {
                 "States -- Albania"
                ,"States -- Algeria"
                ,"States -- Andorra"
                ,"States -- Angola"
                ,"States -- Antigua"
                ,"States -- Barbuda"
                ,"States -- Argentina"
                ,"States -- Armenia"
                ,"States -- Australia"
                ,"States -- Austria"
                ,"States -- Azerbaijan"
                ,"States -- Bahamas"

            };
            var json = JsonConvert.SerializeObject(states);

            return Json(json, JsonRequestBehavior.AllowGet);
        }

        public JsonResult City()
        {
            List<string> cities = new List<string>()
            {
                 "Cities---Albania"
                ,"Cities---Algeria"
                ,"Cities---Andorra"
                ,"Cities---Angola"
                ,"Cities---Antigua"
                ,"Cities---Barbuda"
                ,"Cities---Argentina"
                ,"Cities---Armenia"
                ,"Cities---Australia"
                ,"Cities---Austria"
                ,"Cities---Azerbaijan"
                ,"Cities---Bahamas"

            };
            var json = JsonConvert.SerializeObject(cities);

            return Json(json , JsonRequestBehavior.AllowGet);
        }
    }
}