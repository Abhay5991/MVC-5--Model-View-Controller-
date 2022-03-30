using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TraditionalRouting
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            //routes.MapRoute(
            //    name: "AllStudents",
            //    url: "students",
            //    defaults:new {controller = "Students", Action = "GetAllStudent" }
            //    );

            //routes.MapRoute(
            //   name: "student",
            //   url: "students/{id}",
            //   defaults: new { controller = "Students", Action = "GetStudent" }
            //   );

            //routes.MapRoute(
            //   name: "studentAddress",
            //   url: "students/{id}/Address",
            //   defaults: new { controller = "Students", Action = "GetStudentAddress" }
            //   constraints: new {id=@"\d+"}
            //   );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
