//using System.Collections.Generic;
//using SimpleInjector;
//using SimpleInjector.Integration.Web;
//using System;
//using System.Linq;
//using System.Reflection;
//using Warp.IoC;

//namespace Warp.WebUI.Infrastructure.IoC
//{
//    /// <summary>
//    /// An implementation of IDependencyRegistrar that interfaces with SimpleInjector.
//    /// </summary>
//    public class SimpleInjectorDependencyRegistrar : IDependencyRegistrar
//    {
//        private class Registration
//        {
//            public Type ServiceType { get; set; }
//            public Type ImplementationType { get; set; }
//        }

//        private readonly Container _container;

//        public SimpleInjectorDependencyRegistrar(Container container)
//        {
//            _container = container;
//        }

//        public void RegisterAllImplementationsInThisAssemblyOfType<TService>(LifetimeScope scope)
//            where TService : class
//        {
//            var assembly = Assembly.GetCallingAssembly();

//            RegisterAllTypesInAssembly(assembly, typeof(TService), scope);
//        }

//        public void RegisterAllImplementationsInAssemblyOfType<TService>(LifetimeScope scope, Assembly assembly) where TService : class
//        {
//            RegisterAllTypesInAssembly(assembly, typeof(TService), scope);
//        }

//        public void RegisterAllImplementationsInThisAssemblyOfType(Type serviceType, LifetimeScope scope)
//        {
//            var assembly = Assembly.GetCallingAssembly();

//            RegisterAllTypesInAssembly(assembly, serviceType, scope);
//        }

//        public void RegisterAllImplementationsInAssemblyOfType(Type serviceType, LifetimeScope scope, Assembly assembly)
//        {
//            RegisterAllTypesInAssembly(assembly, serviceType, scope);
//        }

//        public void RegisterAllImplementationsInThisAssembly(LifetimeScope scope)
//        {
//            var registrations = Assembly.GetCallingAssembly()
//                .GetExportedTypes()
//                .Where(t => t.GetInterfaces().Any())
//                .Select(GetServiceAndImplementationRegistration);

//            RegisterAllTypes(registrations, scope);
//        }

//        private void RegisterAllTypesInAssembly(Assembly assembly, Type type, LifetimeScope scope)
//        {
//            // Find all concretes of the supplied abstract.
//            var registrations = assembly
//                .GetExportedTypes()
//                .Where(t => t.GetInterfaces().Any(i => i.FullName == type.FullName))
//                .Select(GetServiceAndImplementationRegistration);

//            RegisterAllTypes(registrations, scope);
//        }

//        public void Register<TService, TImplementation>(LifetimeScope scope)
//            where TService : class
//            where TImplementation : class, TService
//        {
//            _container.Register<TService, TImplementation>(GetLifeStyle(scope));
//        }

//        private Registration GetServiceAndImplementationRegistration(Type concreteType)
//        {
//            Type serviceType;

//            if (concreteType.BaseType != null)
//            {
//                var baseInterfaces = concreteType.BaseType
//                    .GetInterfaces();

//                serviceType = concreteType
//                    .GetInterfaces()
//                    .Except(baseInterfaces)
//                    .Single();
//            }
//            else
//            {
//                serviceType = concreteType
//                    .GetInterfaces()
//                    .Single();
//            }

//            return new Registration
//            {
//                ServiceType = serviceType,
//                ImplementationType = concreteType
//            };
//        }

//        private void RegisterAllTypes(IEnumerable<Registration> registrations, LifetimeScope scope)
//        {
//            foreach (var registration in registrations)
//            {
//                _container.Register(registration.ServiceType, registration.ImplementationType, GetLifeStyle(scope));
//            }
//        }
        
//        private static Lifestyle GetLifeStyle(LifetimeScope scope)
//        {
//            switch (scope)
//            {
//                case LifetimeScope.PerRequest :
//                    return new WebRequestLifestyle(true);

//                case LifetimeScope.Singleton :
//                    return Lifestyle.Singleton;
//            }

//            return Lifestyle.Transient;
//        }
//    }
//}