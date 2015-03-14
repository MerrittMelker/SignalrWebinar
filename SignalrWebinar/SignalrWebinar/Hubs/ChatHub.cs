using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalrWebinar.Hubs
{
    public class ChatHub : Hub
    {
        public void SendMessage(string message)
        {
            Clients.Caller.broadcastMessage("Me: " + message);
            Clients.Others.broadcastMessage("Anon: " + message);
        }
    }
}