using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalrWebinar.Hubs
{
    public class WidgetHub : Hub
    {
        public static int WidgetCount { get; set; }    
    }
}