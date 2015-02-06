using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(razorAngular.Startup))]
namespace razorAngular
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
