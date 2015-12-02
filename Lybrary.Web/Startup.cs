using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lybrary.Web.Startup))]
namespace Lybrary.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
