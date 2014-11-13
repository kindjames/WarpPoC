using System.Web.Mvc;
using Warp.IoC;

namespace Warp.WebUI
{
    public class IoCConfig
    {
        public static void RegisterBindings()
        {
            DependencyResolver.SetResolver(CompositionRoot.GetFullyRegisteredContainer());
        }
    }
}