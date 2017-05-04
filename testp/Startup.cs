using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testp.Startup))]
namespace testp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
