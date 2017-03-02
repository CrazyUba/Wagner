using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wagner3.Startup))]
namespace Wagner3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
