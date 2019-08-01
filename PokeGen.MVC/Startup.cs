using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PokeGen.MVC.Startup))]
namespace PokeGen.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
