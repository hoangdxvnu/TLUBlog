using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TLU.Blog.Startup))]
namespace TLU.Blog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
