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
            Clients.All.broadcastMessage(message);
        }
    }
}