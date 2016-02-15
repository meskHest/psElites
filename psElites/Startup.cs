using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(psElites.Startup))]
namespace psElites
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
