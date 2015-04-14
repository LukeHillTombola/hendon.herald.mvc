using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HendonHerald.Startup))]
namespace HendonHerald
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
