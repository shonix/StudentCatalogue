using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentCatalog3.Startup))]
namespace StudentCatalog3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
