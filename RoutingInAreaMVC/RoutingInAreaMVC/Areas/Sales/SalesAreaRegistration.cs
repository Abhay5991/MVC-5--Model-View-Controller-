using System.Web.Mvc;

namespace RoutingInAreaMVC.Areas.Sales
{
    public class SalesAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Sales";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Sales_default",
                "Sales/{controller}/{action}/{id}",
                new {Controller= "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}