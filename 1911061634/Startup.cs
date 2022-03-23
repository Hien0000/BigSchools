using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1911061634.Startup))]
namespace _1911061634
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
