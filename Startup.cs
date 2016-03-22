using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_and_AngularJS.Startup))]
namespace MVC_and_AngularJS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
