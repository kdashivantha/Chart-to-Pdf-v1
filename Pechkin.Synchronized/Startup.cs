using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pechkin.Synchronized.Startup))]
namespace Pechkin.Synchronized
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
