using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using DL;

namespace DependencyInjectionMVC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IEmployee, Custom>();
            container.RegisterType<IStudent, Student>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}