using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

namespace Warp.WebUI
{
    public partial class Startup
    {
        public void ConfigureAuthentication(IAppBuilder app)
        {
            var url = new UrlHelper(HttpContext.Current.Request.RequestContext);

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString(url.Action("Login", "Authentication"))
            });
        }
    }
}