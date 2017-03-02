using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wagner2.Startup))]
namespace Wagner2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
