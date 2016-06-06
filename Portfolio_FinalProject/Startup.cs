using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Portfolio_FinalProject.Startup))]
namespace Portfolio_FinalProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
