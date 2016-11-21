using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Pawi.Hololens.DummyApi.Startup))]

namespace Pawi.Hololens.DummyApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
