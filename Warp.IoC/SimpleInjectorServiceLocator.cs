using System;
using SimpleInjector;
using Warp.Core.Infrastructure.IoC;

namespace Warp.IoC
{
    /// <summary>
    /// A service locator that interfaces with SimpleInjector.
    /// </summary>
    public class SimpleInjectorServiceLocator : IServiceLocator
    {
        private readonly Container _container;

        public SimpleInjectorServiceLocator(Container container)
        {
            _container = container;
        }

        public object TryResolve(Type type)
        {
            if (_container.GetRegistration(type, false) != null)
            {
                return _container.GetInstance(type);
            }

            return null;
        }

        public TService TryResolve<TService>()
            where TService : class
        {
            if (_container.GetRegistration(typeof(TService), false) != null)
            {
                return _container.GetInstance<TService>();
            }

            return null;
        }
    }
}