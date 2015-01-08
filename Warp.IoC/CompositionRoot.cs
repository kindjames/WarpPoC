using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Microsoft.AspNet.Identity;
using SimpleInjector;
using SimpleInjector.Advanced;
using SimpleInjector.Extensions;
using SimpleInjector.Integration.Web.Mvc;
using Warp.Core.Command;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.Configuration;
using Warp.Core.Infrastructure.IoC;
using Warp.Core.Infrastructure.Models;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Core.Util;
using Warp.Data.Context;
using Warp.Data.Queries.General;
using Warp.Data.Validation;
using Warp.IoC.Factories;
using Warp.Services;
using IObjectMapper = Warp.Core.Infrastructure.AutoMapper.IObjectMapper;
using PasswordHasher = Warp.Core.Infrastructure.Authentication.PasswordHasher;

namespace Warp.IoC
{
    public enum LifeStyle
    {
        Transient,
        Singleton,
    }

    public class SimpleInjectorWrapper : IDependencyContainer
    {
        private readonly Container _container;

        public SimpleInjectorWrapper(Container container)
        {
            _container = container;
        }

        static Lifestyle To(LifeStyle lifeStyle)
        {
            return (lifeStyle == LifeStyle.Transient) ? Lifestyle.Transient : Lifestyle.Singleton;
        }

        public void Register(Type serviceType, Type concreteType, LifeStyle lifeStyle = LifeStyle.Transient)
        {
            _container.Register(serviceType, concreteType, To(lifeStyle));
        }

        public void Register<TService, TImplementation>(LifeStyle lifeStyle = LifeStyle.Transient) where TService : class where TImplementation : class, TService
        {
            _container.Register<TService, TImplementation>(To(lifeStyle));
        }

        public void Register<TService>(Func<TService> instanceCreator, LifeStyle lifeStyle = LifeStyle.Transient) where TService : class
        {
            _container.Register(instanceCreator, To(lifeStyle));
        }

        public void RegisterPerWebRequest<TService>(Func<TService> instanceCreator) where TService : class
        {
            _container.RegisterPerWebRequest<TService>(instanceCreator);
        }

        public bool IsVerifying()
        {
            return _container.IsVerifying();
        }

        public TService GetInstance<TService>() where TService : class
        {
            return _container.GetInstance<TService>();
        }

        public void RegisterManyForOpenGeneric(Type openGenericServiceType, params Assembly[] assemblies)
        {
            _container.RegisterManyForOpenGeneric(openGenericServiceType, assemblies);
        }

        public void RegisterMvcControllers(params Assembly[] assemblies)
        {
            _container.RegisterMvcControllers(assemblies);
        }

        public void RegisterMvcIntegratedFilterProvider()
        {
            _container.RegisterMvcIntegratedFilterProvider();
        }
    }

    public interface IDependencyContainer
    {
        void Register(Type serviceType, Type concreteType, LifeStyle lifeStyle = LifeStyle.Transient);
        void Register<TService, TImplementation>(LifeStyle lifeStyle = LifeStyle.Transient) where TService : class where TImplementation : class, TService;
        void Register<TService>(Func<TService> instanceCreator, LifeStyle lifeStyle = LifeStyle.Transient) where TService : class;
        void RegisterPerWebRequest<TService>(Func<TService> instanceCreator) where TService : class;
        bool IsVerifying();
        TService GetInstance<TService>() where TService : class;
        void RegisterManyForOpenGeneric(Type openGenericServiceType, params Assembly[] assemblies);
        void RegisterMvcControllers(params Assembly[] assemblies);
        void RegisterMvcIntegratedFilterProvider();
    }

    public static class CompositionRoot
    {
        public static void ApplyAllDependencyBindings(IDependencyContainer c)
        {
            // AutoMapper
            c.Register(() => Mapper.Engine);
            c.Register(() => Mapper.Configuration);

            // IoC
            c.Register<ITextResourceModelProvider, TextResourceModelProvider>();

            // Core
            c.Register<IDateTimeProvider, DateTimeProvider>();
            c.Register<IValidator, DataAnnotationsValidator>();
            c.Register<IApplicationConfig, ApplicationConfig>();
            c.Register<IObjectMapper, ObjectMapper>();

            // Data
            var dataAssembly = typeof(IDomainDbContext).Assembly;
            c.Register<ICommandDispatcher, CommandDispatcher>();
            c.Register<IQueryDispatcher, QueryDispatcher>();
            c.RegisterManyForOpenGeneric(typeof(ICommandHandler<>), dataAssembly);
            c.RegisterManyForOpenGeneric(typeof(IQueryHandler<,>), dataAssembly);
            c.RegisterAllImplementationsInAssemblyWithNameEnding("DbContext", dataAssembly);
            c.RegisterOpenGenericQueryHandlerForAllEntityTypes(typeof(CheckEntityExistsQuery<>), typeof(CheckEntityExistsQueryHandler<>));

            // Services
            var serviceAssembly = typeof(ClientService).Assembly;
            c.RegisterAllImplementationsInAssemblyWithNameEnding("Service", serviceAssembly);

            // MVC
            var mvcAssembly = Assembly.GetCallingAssembly();
            c.RegisterMvcControllers(mvcAssembly);
            c.RegisterMvcIntegratedFilterProvider();

            // Web
            c.RegisterPerWebRequest<HttpContextBase>(() => new HttpContextWrapper(HttpContext.Current));
            c.RegisterPerWebRequest<HttpRequestBase>(() => new HttpRequestWrapper(HttpContext.Current.Request));
            c.RegisterPerWebRequest<HttpResponseBase>(() => new HttpResponseWrapper(HttpContext.Current.Response));

            // Identity
            c.Register<IPasswordHasher, PasswordHasher>();
            c.Register(() => c.GetInstance<UserManagerFactory>().Build());
            c.RegisterPerWebRequest(() => c.GetInstance<AuthenticationManagerFactory>().Build(c.IsVerifying()));
        }

        /// <summary>
        /// Responsible for registering all DI bindings within the project.
        /// </summary>
        public static IDependencyResolver GetFullyRegisteredContainer()
        {
            var c = new Container();
            c.Options.PropertySelectionBehavior = new PropertySelectionBehavior<InjectDependencyAttribute>();

            var co = new SimpleInjectorWrapper(c);
            ApplyAllDependencyBindings(co);

            c.Register<IServiceLocator, SimpleInjectorServiceLocator>();

            c.Verify();
            
            return new SimpleInjectorDependencyResolver(c);
        }
    }
}