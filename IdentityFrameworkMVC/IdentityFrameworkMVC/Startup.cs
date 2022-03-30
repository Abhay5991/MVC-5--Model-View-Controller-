using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityFrameworkMVC.Startup))]
namespace IdentityFrameworkMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
