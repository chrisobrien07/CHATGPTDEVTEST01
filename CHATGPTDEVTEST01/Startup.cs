using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CHATGPTDEVTEST01.Startup))]
namespace CHATGPTDEVTEST01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
