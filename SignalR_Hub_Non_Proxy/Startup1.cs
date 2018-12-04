using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalR_Hub_Non_Proxy.Startup1))]

namespace SignalR_Hub_Non_Proxy
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            // 有关如何配置应用程序的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkID=316888
            app.MapSignalR("/myhub", new Microsoft.AspNet.SignalR.HubConfiguration());
        }
    }
}
