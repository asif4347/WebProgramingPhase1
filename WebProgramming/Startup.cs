using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebProgramming.Startup))]
namespace WebProgramming
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
