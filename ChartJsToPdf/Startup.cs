using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChartJsToPdf.Startup))]
namespace ChartJsToPdf
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
