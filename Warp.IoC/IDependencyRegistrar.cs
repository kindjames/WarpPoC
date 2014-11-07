using System;
using System.Reflection;

namespace Warp.IoC
{
    /// <summary>
    /// A contract for registering depencencies - allows swap-out of DI container.
    /// </summary>
    public interface IDependencyRegistrar
    {
        void RegisterAllImplementationsInThisAssemblyOfType<TService>(LifetimeScope scope)
            where TService : class;

        void RegisterAllImplementationsInAssemblyOfType<TService>(LifetimeScope scope, Assembly assembly)
            where TService : class;

        void RegisterAllImplementationsInThisAssemblyOfType(Type serviceType, LifetimeScope scope);

        void RegisterAllImplementationsInAssemblyOfType(Type serviceType, LifetimeScope scope, Assembly assembly);

        void Register<TService, TImplementation>(LifetimeScope scope)
            where TService : class
            where TImplementation : class, TService;

        void RegisterAllImplementationsInThisAssembly(LifetimeScope scope);
    }
}