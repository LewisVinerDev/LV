using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LV.Startup))]
namespace LV
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
