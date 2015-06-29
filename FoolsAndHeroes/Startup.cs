using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoolsAndHeroes.Startup))]
namespace FoolsAndHeroes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
