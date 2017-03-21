using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bandbook.Startup))]
namespace Bandbook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
