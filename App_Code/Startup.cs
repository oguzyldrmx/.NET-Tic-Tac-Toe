using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tic_Tac_Toe.Startup))]
namespace Tic_Tac_Toe
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
