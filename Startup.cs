using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(themeIntegrationMvc.Startup))]
namespace themeIntegrationMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
