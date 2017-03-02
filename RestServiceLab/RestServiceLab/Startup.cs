using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestServiceLab.Startup))]
namespace RestServiceLab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
