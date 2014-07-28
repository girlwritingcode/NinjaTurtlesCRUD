using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NinjaTurtlesMVC.Web.Startup))]
namespace NinjaTurtlesMVC.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
