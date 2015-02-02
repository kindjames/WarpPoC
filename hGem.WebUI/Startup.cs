using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using hGem.WebUI;
using Microsoft.Owin;
using Owin;
using Mapper = AutoMapper.Mapper;

[assembly: OwinStartup(typeof(Startup))]
namespace hGem.WebUI
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
            ConfigureFluentValidation();
        }
    }
}