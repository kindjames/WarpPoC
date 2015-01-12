using System.Web.Mvc;
using System.Web.Routing;

namespace Warp.WebUI
{
    public partial class Startup
    {
        public static void ConfigureRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Default", "{controller}/{action}/{id}", new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }

        public static void ConfigureAttributeRouting(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes();
        }
    }
}