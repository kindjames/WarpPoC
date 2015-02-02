using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FluentValidation;
using hGem.Core.Cqrs;
using hGem.Core.Data;
using SimpleInjector;
using SimpleInjector.Extensions;

namespace hGem.IoC.Util
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

        public static void RegisterOpenGenericQueryHandlerForAllEntityTypesWithEntityResultType(this Container container, Type openQueryType, Type openQueryHandlerType)
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

        public static void RegisterOpenGenericQueryHandlerForAllEntityTypesWithEnumerableEntityResultType(this Container container, Type openQueryType, Type openQueryHandlerType)
        {
            var openQueryHandlerInterfaceType = typeof(IQueryHandler<,>);

            foreach (var entityType in EntityTypes.Value)
            {
                var resultType = typeof (IEnumerable<>).MakeGenericType(entityType);
                var closedQueryType = openQueryType.MakeGenericType(entityType);
                var closedHandlerInterfaceType = openQueryHandlerInterfaceType.MakeGenericType(closedQueryType, resultType);
                var closedQueryHandlerType = openQueryHandlerType.MakeGenericType(entityType);

                container.Register(closedHandlerInterfaceType, closedQueryHandlerType);
            }
        }

        /// <summary>
        /// This registers the Query with the Query Handler, for all Entity types. This allows the reuse of a generic Query for all different Entities.
        /// </summary>
        /// <param name="container"></param>
        /// <param name="openQueryType"></param>
        /// <param name="openQueryHandlerType"></param>
        /// <param name="resultType"></param>
        public static void RegisterOpenGenericQueryHandlerForAllEntityTypesWithSpecifiedResultType(this Container container, Type openQueryType, Type openQueryHandlerType, Type resultType)
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

        /// <summary>
        /// Registers the generic AbstractValidator for all Entity types, e.g. EntityExistsValidator<TheEntity> could validate the Entity exists.
        /// </summary>
        /// <param name="container"></param>
        /// <param name="openValidatorType"></param>
        public static void RegisterOpenGenericValidatorForAllEntityTypes(this Container container, Type openValidatorType)
        {
            foreach (var closedCommandType in EntityTypes.Value.Select(e => openValidatorType.MakeGenericType(e)))
            {
                container.Register(closedCommandType);
            }
        }
        
        /// <summary>
        /// Registers the Command with the Command Handler for all Entity types. This allows the re-use of a generic Command for all data Entities, e.g. DeleteEntityCommand<TheEntity>
        /// </summary>
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

        /// <summary>
        /// Finds all MVC Controllers in the Assembly(s), excluding T4MVC generated 
        /// <param name="assemblies">The assemblies containing the Controllers</param>
        /// </summary>
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
        /// <param name="assembly">The assembly containing the AbstractValidator's</param>
        public static void RegisterAllFluentValidatorsInAssembly(this Container container, Assembly assembly)
        {
            container.RegisterManyForOpenGeneric(typeof(AbstractValidator<>), assembly);
        }
    }
}