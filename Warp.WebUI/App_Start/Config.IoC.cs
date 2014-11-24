using System.Web.Mvc;
using Warp.IoC;

namespace Warp.WebUI
{
    public partial class Startup
    {
        public void ConfigureIocBindings()
        {
            DependencyResolver.SetResolver(CompositionRoot.GetFullyRegisteredContainer());
        }
    }
}