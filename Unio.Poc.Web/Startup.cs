using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Unio.Poc.Web.Startup))]
namespace Unio.Poc.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
