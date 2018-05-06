using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assi_Final_Web.Startup))]
namespace Assi_Final_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
