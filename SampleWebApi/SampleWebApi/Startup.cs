using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleWebApi.Startup))]
namespace SampleWebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
