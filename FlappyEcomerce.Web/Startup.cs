using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlappyEcomerce.Web.Startup))]
namespace FlappyEcomerce.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
