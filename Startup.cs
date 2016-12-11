using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Consultancy.Startup))]
namespace Consultancy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
