using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MainDMMM.Startup))]
namespace MainDMMM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
