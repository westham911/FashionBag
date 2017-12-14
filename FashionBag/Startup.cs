using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FashionBag.Startup))]
namespace FashionBag
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
