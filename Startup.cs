using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobForFreeTime.Startup))]
namespace JobForFreeTime
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
