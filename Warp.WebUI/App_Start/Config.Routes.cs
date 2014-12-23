using System.Web.Mvc;
using System.Web.Routing;

namespace Warp.WebUI
{
    public partial class Startup
    {
        public void ConfigureRouting(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute("Default", "{controller}/{action}/{id}", new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}