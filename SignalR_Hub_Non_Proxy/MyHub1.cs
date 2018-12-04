using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalR_Hub_Non_Proxy
{
    [HubName("PersonHub")]
    public class MyHub1 : Hub
    {
        public void Hello()
        {
            Clients.All.hello("welcome");
        }
        [HubMethodName("newWelcome")]
        public void Welcome()
        {
            string uname = Context.QueryString["username"];
            string uid = Context.QueryString["userid"];
            Clients.All.welcome("i am new welcome");
        }
    }
}