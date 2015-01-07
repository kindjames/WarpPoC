using System;
using SimpleInjector;
using Warp.Core.Infrastructure.IoC;

namespace Warp.IoC
{
    /// <summary>
    /// A service locator that interfaces with SimpleInjector.
    /// </summary>
    public class ServiceLocator : IServiceLocator
    {
        private readonly Container _container;

        public ServiceLocator(Container container)
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

        public TService Create<TService>()
            where TService : class
        {
            return _container.GetInstance<TService>();
        }
    }
}