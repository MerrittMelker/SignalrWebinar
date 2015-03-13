using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalrWebinar.Startup))]
namespace SignalrWebinar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
