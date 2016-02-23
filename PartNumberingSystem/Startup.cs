using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PartNumberingSystem.Startup))]
namespace PartNumberingSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
