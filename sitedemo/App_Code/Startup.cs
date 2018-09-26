using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sitedemo.Startup))]
namespace sitedemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
