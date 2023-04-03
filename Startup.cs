using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuanLiTrangThietBi.Startup))]
namespace QuanLiTrangThietBi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
