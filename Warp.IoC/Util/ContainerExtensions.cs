using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using SimpleInjector;
using Warp.Core.Command;
using Warp.Core.Data;
using Warp.Core.Query;

namespace Warp.IoC
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

        private static readonly IEnumerable<Type> EntityTypes;

        static ContainerExtensions()
        {
            EntityTypes = typeof(EntityBase).Assembly
                .GetExportedTypes()
                .Where(t => t.Namespace == "Warp.Data.Entities")
                .Where(t => !t.IsAbstract)
                .Where(t => t.IsClass)
                .Where(t => typeof (EntityBase).IsAssignableFrom(t));
        }

        public static void RegisterOpenGenericQueryHandlerForAllEntityTypes(this Container container, Type openQueryType, Type openQueryHandlerType)
        {
            var openQueryHandlerInterfaceType = typeof(IQueryHandler<,>);
            
            foreach (var entityType in EntityTypes)
            {
                var closedDeleteCommandType = openQueryType.MakeGenericType(entityType);
                var closedHandlerInterfaceType = openQueryHandlerInterfaceType.MakeGenericType(closedDeleteCommandType, typeof(bool));
                var closedDeleteCommandHandlerType = openQueryHandlerType.MakeGenericType(entityType);

                container.Register(closedHandlerInterfaceType, closedDeleteCommandHandlerType);
            }
        }

        public static void RegisterOpenGenericCommandHandlerForAllEntityTypes(this Container container, Type openCommandType, Type openCommandHandlerType)
        {
            var openCommandHandlerInterfaceType = typeof(ICommandHandler<>);
            
            foreach (var entityType in EntityTypes)
            {
                var closedDeleteCommandType = openCommandType.MakeGenericType(entityType);
                var closedHandlerInterfaceType = openCommandHandlerInterfaceType.MakeGenericType(closedDeleteCommandType, typeof(bool));
                var closedDeleteCommandHandlerType = openCommandHandlerType.MakeGenericType(entityType);

                container.Register(closedHandlerInterfaceType, closedDeleteCommandHandlerType);
            }
        }
    }
}