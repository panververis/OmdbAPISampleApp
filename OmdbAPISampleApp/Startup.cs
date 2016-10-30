using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OmdbAPISampleApp.Startup))]
namespace OmdbAPISampleApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
