using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(RMSWebServices.Startup))]

namespace RMSWebServices
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}