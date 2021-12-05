using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PaddleApp.Startup))]
namespace PaddleApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
