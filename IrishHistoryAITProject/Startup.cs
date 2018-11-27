using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IrishHistoryAITProject.Startup))]
namespace IrishHistoryAITProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
