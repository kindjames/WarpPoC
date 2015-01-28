using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FluentValidation;
using SimpleInjector;
using SimpleInjector.Extensions;
using Warp.Core.Cqrs;
using Warp.Core.Data;

namespace Warp.IoC.Util
{
    public static class ContainerExtensions
    {
        /// <summary>
        /// Registers all implementations with the IoC Container. Uses a name-ending to search on.
        /// </summary>
        /// <param name="container"></param>
        /// <param name="serviceNameEnding">Name ending of the services to register, e.g. "Service" would register "UserService".</param>
        /// <param name="assembly">Assembly to search.</param>
        public static void RegisterAllImplementationsInAssemblyWithNameEnding(this Container container, string serviceNameEnding, Assembly assembly)
        {
            // Get all types.
            assembly.ExportedTypes
                .Where(t => !t.IsInterface) // That aren't an interface
                .Where(t => t.GetInterfaces().Any()) // That implement an interface
                .Where(t => t.FullName.EndsWith(serviceNameEnding)) // That has a name ending
                .Select(t => new
                {
                    Implementation = t, // The implementation's type
                    Service = t.BaseType == null // The interface it implements.
                        ? t.GetInterfaces().First() // NB. Excludes any interfaces that it inherits from its base class(es).
                        : t.GetInterfaces().Except(t.BaseType.GetInterfaces()).First()
                })
                .ToList() // Convert to a list and register each implementation with its interface.
                .ForEach(t => container.Register(t.Service, t.Implementation));
        }

        private static readonly Lazy<IEnumerable<Type>> EntityTypes = new Lazy<IEnumerable<Type>>(() =>
        {
            return AppDomain.CurrentDomain
                .GetAssemblies()
                .Single(a => a.FullName.Contains("Warp.Data"))
                .GetExportedTypes()
                .Where(t => t.Namespace == "Warp.Data.Entities")
                .Where(t => !t.IsAbstract)
                .Where(t => t.IsClass)
                .Where(t => typeof(EntityBase).IsAssignableFrom(t));
        });

        public static void RegisterOpenGenericQueryHandlerForAllEntityTypes(this Container container, Type openQueryType, Type openQueryHandlerType)
        {
            var openQueryHandlerInterfaceType = typeof(IQueryHandler<,>);

            foreach (var entityType in EntityTypes.Value)
            {
                var closedQueryType = openQueryType.MakeGenericType(entityType);
                var closedHandlerInterfaceType = openQueryHandlerInterfaceType.MakeGenericType(closedQueryType, entityType);
                var closedQueryHandlerType = openQueryHandlerType.MakeGenericType(entityType);

                container.Register(closedHandlerInterfaceType, closedQueryHandlerType);
            }
        }

        public static void RegisterOpenGenericQueryHandlerForAllEntityTypes(this Container container, Type openQueryType, Type openQueryHandlerType, Type resultType)
        {
            var openQueryHandlerInterfaceType = typeof(IQueryHandler<,>);

            foreach (var entityType in EntityTypes.Value)
            {
                var closedQueryType = openQueryType.MakeGenericType(entityType);
                var closedHandlerInterfaceType = openQueryHandlerInterfaceType.MakeGenericType(closedQueryType, resultType);
                var closedQueryHandlerType = openQueryHandlerType.MakeGenericType(entityType);

                container.Register(closedHandlerInterfaceType, closedQueryHandlerType);
            }
        }

        public static void RegisterOpenGenericValidatorForAllEntityTypes(this Container container, Type openValidatorType)
        {
            foreach (var closedCommandType in EntityTypes.Value.Select(e => openValidatorType.MakeGenericType(e)))
            {
                container.Register(closedCommandType);
            }
        }

        public static void RegisterControllers(this Container container, params Assembly[] assemblies)
        {
            SimpleInjectorMvcExtensions.GetControllerTypesToRegister(container, assemblies)
                .Where(t => !t.Name.Contains("T4MVC"))
                .ToList()
                .ForEach(container.Register);
        }

        /// <summary>
        /// Registers all implementations of FluentValidation's AbstractValidator in Assembly.
        /// </summary>
        /// <param name="container"></param>
        /// <param name="assembly"></param>
        public static void RegisterAllFluentValidatorsInAssembly(this Container container, Assembly assembly)
        {
            container.RegisterManyForOpenGeneric(typeof(AbstractValidator<>), assembly);
        }

        public static void RegisterOpenGenericCommandHandlerForAllEntityTypes(this Container container, Type openCommandType, Type openCommandHandlerType)
        {
            var openCommandHandlerInterfaceType = typeof(ICommandHandler<>);

            foreach (var entityType in EntityTypes.Value)
            {
                var closedCommandType = openCommandType.MakeGenericType(entityType);
                var closedHandlerInterfaceType = openCommandHandlerInterfaceType.MakeGenericType(closedCommandType);
                var closedCommandHandlerType = openCommandHandlerType.MakeGenericType(entityType);

                container.Register(closedHandlerInterfaceType, closedCommandHandlerType);
            }
        }
    }
}