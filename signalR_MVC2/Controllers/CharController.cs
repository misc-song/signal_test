using Microsoft.AspNet.SignalR;
using signalR_MVC2.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace signalR_MVC2.Controllers
{
    public class ChatController : BaseController<MyConnection1>
    {
        // GET: Chat
        public ActionResult Index()
        {
            //string connid = Request["connid"].ToString();
            //ConnectionMessage message = new ConnectionMessage("ok", "666");
            //connection.Send(message);
            
            //connectionGroupManager.Add(connid,)
            return View();
        }
    }

}