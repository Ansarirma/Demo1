using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewApplication1.Startup))]
namespace NewApplication1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
