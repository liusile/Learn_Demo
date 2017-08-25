using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Learn_MVCFilter.Startup))]
namespace Learn_MVCFilter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
