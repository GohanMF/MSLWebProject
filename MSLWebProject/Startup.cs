using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MSLWebProject.Startup))]
namespace MSLWebProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
