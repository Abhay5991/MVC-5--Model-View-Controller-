using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomAuthenticationMVC.Filter 
{
    public class AbhayAction : ActionFilterAttribute
    {
        public override void  OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("Hello from Action filter OnActionExecuted");

            filterContext.Controller.ViewBag.Message = "Abhay from Action Filter";
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("Hello from Action filter OnActionExecuting");
        }
    }
}