using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResearchManagementProject.Startup))]
namespace ResearchManagementProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
