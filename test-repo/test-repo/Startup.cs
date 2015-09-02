using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test_repo.Startup))]
namespace test_repo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
