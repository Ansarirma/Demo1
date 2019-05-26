using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewApplicarion1.Startup))]
namespace NewApplicarion1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
