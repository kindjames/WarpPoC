using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Warp.WebUI
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            IoCConfig.RegisterBindings();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}