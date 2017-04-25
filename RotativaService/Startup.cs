using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RotativaService.Startup))]
namespace RotativaService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
