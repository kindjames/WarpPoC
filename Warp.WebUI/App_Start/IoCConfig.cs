using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using System.Web.Mvc;
using Warp.IoC;

namespace Warp.WebUI
{
    public class IoCConfig
    {
        public static void RegisterBindings()
        {
            var container = new Container();
            
            CompositionRoot.RegisterBindings(container);
            
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}