using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KnockBusterMVC.Startup))]
namespace KnockBusterMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
