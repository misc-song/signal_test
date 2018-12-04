using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace signalR_MVC2.Common
{
    public abstract class BaseController<T> : Controller where T : PersistentConnection
    {
        public IConnection connection { get; set; }
        public IConnectionGroupManager connectionGroupManager { get; set; }
        public BaseController()
        {
            var gh = GlobalHost.ConnectionManager.GetConnectionContext<T>();
            connection = gh.Connection;
            connectionGroupManager = gh.Groups;
        }
    }
}