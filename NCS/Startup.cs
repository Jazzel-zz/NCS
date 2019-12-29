using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NCS.Startup))]
namespace NCS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
