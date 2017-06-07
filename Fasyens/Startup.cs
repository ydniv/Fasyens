using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fasyens.Startup))]
namespace Fasyens
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
