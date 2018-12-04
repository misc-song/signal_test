using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace signalR_MVC2
{
    public class MyConnection1 : PersistentConnection
    {
        protected override Task OnConnected(IRequest request, string connectionId)
        {
            // Console.Beep();
            Groups.Add(connectionId, "chatroom");
            return Groups.Send("chatroom", "welcome new member!!!",connectionId);
           // return Connection.Broadcast(connectionId, $"Welcome {connectionId}!");
        }

        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {
            return Groups.Send("chatroom", data);
            //return Connection.Broadcast(data);
        }
    }
}