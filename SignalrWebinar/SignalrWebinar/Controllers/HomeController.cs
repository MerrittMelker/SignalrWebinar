using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.SignalR;
using SignalrWebinar.Hubs;

namespace SignalrWebinar.Controllers
{
    public class HomeController : Controller
    {
        public void CreateWidget()
        {
            WidgetHub.WidgetCount++;
            var widgetHubContext = GlobalHost.ConnectionManager.GetHubContext<WidgetHub>();
            widgetHubContext.Clients.All.updateWidgetCount(WidgetHub.WidgetCount);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult WidgetHubTest()
        {
            return View();
        }
    }
}