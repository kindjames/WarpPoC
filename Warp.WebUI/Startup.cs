using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.Owin;
using Owin;
using Warp.WebUI;
using Mapper = AutoMapper.Mapper;

[assembly: OwinStartup(typeof(Startup))]
namespace Warp.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureIocBindings();
            ConfigureGlobalFilters(GlobalFilters.Filters);
            ConfigureAttributeRouting(RouteTable.Routes);
            ConfigureRoutes(RouteTable.Routes);
            ConfigureBundles(BundleTable.Bundles);
            ConfigureAuthentication(app);
            ConfigureBootstrap();
            ConfigureAutoMapper(Mapper.Configuration);
        }
    }
}