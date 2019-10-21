using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VinylShopWebProject.Startup))]
namespace VinylShopWebProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
