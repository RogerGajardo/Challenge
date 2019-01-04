using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Challenge.Backend.Startup))]
namespace Challenge.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
