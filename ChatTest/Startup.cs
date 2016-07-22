using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatTest.Startup))]
namespace ChatTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
