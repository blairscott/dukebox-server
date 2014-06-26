using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dukeBox.Web.Startup))]
namespace dukeBox.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
