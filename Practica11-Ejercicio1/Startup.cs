using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practica11_Ejercicio1.Startup))]
namespace Practica11_Ejercicio1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
