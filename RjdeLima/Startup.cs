using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RjdeLima.Startup))]
namespace RjdeLima
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
