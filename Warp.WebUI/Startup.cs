﻿using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.Owin;
using Owin;
using Warp.WebUI;

[assembly: OwinStartup(typeof(Startup))]
namespace Warp.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuthentication(app);
            ConfigureIocBindings();
            //AreaRegistration.RegisterAllAreas();
            ConfigureGlobalFilters(GlobalFilters.Filters);
            ConfigureRouting(RouteTable.Routes);
            ConfigureBundles(BundleTable.Bundles);
        }
    }
}