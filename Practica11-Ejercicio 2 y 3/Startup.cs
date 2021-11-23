using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practica11_Ejercicio2.Startup))]
namespace Practica11_Ejercicio2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
