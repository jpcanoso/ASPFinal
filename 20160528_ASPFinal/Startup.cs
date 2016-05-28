using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_20160528_ASPFinal.Startup))]
namespace _20160528_ASPFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
