using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookEvents.Web.Startup))]
namespace BookEvents.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
