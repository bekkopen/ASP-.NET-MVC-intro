using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCintro.Startup))]
namespace MVCintro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
