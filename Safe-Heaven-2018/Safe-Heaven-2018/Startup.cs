using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Safe_Heaven_2018.Startup))]
namespace Safe_Heaven_2018
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
