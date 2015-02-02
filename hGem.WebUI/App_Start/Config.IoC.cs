using System.Web.Mvc;
using hGem.IoC;

namespace hGem.WebUI
{
    public partial class Startup
    {
        public static void ConfigureIocBindings()
        {
            DependencyResolver.SetResolver(CompositionRoot.GetFullyRegisteredContainer());
        }
    }
}