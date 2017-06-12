using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MolelDB.Startup))]
namespace MolelDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
