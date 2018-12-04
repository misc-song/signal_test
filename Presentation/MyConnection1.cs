using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using Newtonsoft.Json;

namespace Presentation
{
    public class MyConnection1 : PersistentConnection
    {


        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {
            var model = JsonConvert.DeserializeObject<MyTest>(data);
            if (model.Msg == "welcome")
            {
                Groups.Add(connectionId, model.Room);
                return Groups.Send(model.Room, "welcome new member!!!", connectionId);
            }
            else
            {
                 return Groups.Send(model.Room,$"{model.Msg}");
            }
        }

    }
    public class MyTest
    {
        // public string Characterristic { get; set; }
        public string Msg { get; set; }
        public string Room { get; set; }
    }
}