using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(signalR_MVC2.Startup))]
namespace signalR_MVC2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
