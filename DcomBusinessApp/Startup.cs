using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DcomBusinessApp.Startup))]
namespace DcomBusinessApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
