using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XtendableExports.Startup))]
namespace XtendableExports
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
