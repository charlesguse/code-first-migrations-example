using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LocalVariablesExample.Startup))]
namespace LocalVariablesExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
