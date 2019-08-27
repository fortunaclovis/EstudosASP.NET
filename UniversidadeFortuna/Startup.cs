using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UniversidadeFortuna.Startup))]
namespace UniversidadeFortuna
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
