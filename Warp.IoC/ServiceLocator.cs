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
            try
            {
                return _container.GetInstance(type);
            }
            catch
            {
                return null;
            }
        }

        public TService TryResolve<TService>()
            where TService : class
        {
            try
            {
                return _container.GetInstance<TService>();
            }
            catch
            {
                return null;
            }
        }
    }
}