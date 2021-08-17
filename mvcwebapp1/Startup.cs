using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcwebapp1.Startup))]
namespace mvcwebapp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
