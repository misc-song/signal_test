using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Presentation.Startup1))]

namespace Presentation
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            // 有关如何配置应用程序的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkID=316888
            // app.MapSignalR<MyConnection1>("/myconn");
            app.Map("/myconn", (map) =>
            {
                //添加jsonp和cors 以进行跨域访问
                map.RunSignalR<MyConnection1>(new Microsoft.AspNet.SignalR.ConnectionConfiguration() { EnableJSONP = true });
                map.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            });

        }
    }
}
