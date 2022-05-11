using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aleksandar_Karapanchevski_INKI708.Startup))]
namespace Aleksandar_Karapanchevski_INKI708
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
