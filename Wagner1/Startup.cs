using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wagner1.Startup))]
namespace Wagner1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
