using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(dukeBox.App_Start.Startup))]

namespace dukeBox.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            app.MapSignalR();
            var results = Subsonic.LogIn("dhulk.jumpingcrab.com:4040", "dhulk", "hbkk12");

        }
    }
}
