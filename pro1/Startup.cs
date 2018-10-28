using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pro1.Startup))]
namespace pro1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

    }
}
