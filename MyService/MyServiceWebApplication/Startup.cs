using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyServiceWebApplication.Startup))]
namespace MyServiceWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
