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
    public static class CompositionRoot
    {
        /// <summary>
        /// Responsible for registering all DI bindings within the project.
        /// </summary>
        public static IDependencyResolver GetFullyRegisteredContainer()
        {
            var c = new Container();
            c.Options.PropertySelectionBehavior = new PropertySelectionBehavior<InjectDependencyAttribute>();

            // AutoMapper
            c.Register(typeof(IMappingEngine), () => Mapper.Engine);
            c.Register(typeof(IConfigurationProvider), () => Mapper.Configuration);

            // IoC
            c.Register<IServiceLocator, SimpleInjectorServiceLocator>();
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

            c.Verify();

            return new SimpleInjectorDependencyResolver(c);
        }
    }
}