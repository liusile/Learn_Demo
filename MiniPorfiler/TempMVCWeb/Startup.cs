using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TempMVCWeb.Startup))]
namespace TempMVCWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
