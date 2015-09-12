using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RepositorySample.Application.Services.Startup))]
namespace RepositorySample.Application.Services
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
