using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_26november.Startup))]
namespace _26november
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
