using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComplejoDeCines.Startup))]
namespace ComplejoDeCines
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
