using System.Web.Mvc;

namespace Warp.WebUI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new Elmah.Contrib.Mvc.ElmahHandleErrorAttribute());
        }
    }
}
