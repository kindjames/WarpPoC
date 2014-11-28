using System.Linq;
using AutoMapper;
using Microsoft.AspNet.Identity;
using SimpleInjector;
using SimpleInjector.Advanced;
using SimpleInjector.Extensions;
using SimpleInjector.Integration.Web.Mvc;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Warp.Core.Command;
using Warp.Core.Infrastructure.Configuration;
using Warp.Core.Infrastructure.IoC;
using Warp.Core.Infrastructure.Mapping;
using Warp.Core.Infrastructure.Models;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Core.Services;
using Warp.Core.Util;
using Warp.Data.Context;
using Warp.IoC.Factories;
using Warp.Services;
using IObjectMapper = Warp.Core.Infrastructure.Mapping.IObjectMapper;
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

            // AutoMapper
            c.Register(typeof(IMappingEngine), () => Mapper.Engine);

            // IoC
            c.Register<IServiceLocator, ServiceLocator>();
            c.Register<ITextResourceModelProvider, TextResourceModelProvider>();

            // Core
            c.Register<IDateTimeProvider, DateTimeProvider>();
            c.Register<IObjectMapper, ObjectMapper>();
            c.Register<IValidator, DataAnnotationsValidator>();
            c.Register<IApplicationConfig, ApplicationConfig>();

            // Data
            var dataAssembly = typeof(IDomainDbContext).Assembly;
            c.Register<ICommandDispatcher, CommandDispatcher>();
            c.Register<IQueryDispatcher, QueryDispatcher>();
            c.RegisterManyForOpenGeneric(typeof(ICommandHandler<>), dataAssembly);
            c.RegisterManyForOpenGeneric(typeof(IQueryHandler<,>), dataAssembly);
            c.RegisterManyForOpenGeneric(typeof(IMappingConfiguration<,>), dataAssembly);
            c.RegisterPerWebRequest<IDomainDbContext, DomainDbContext>();
            c.RegisterPerWebRequest<IAuthenticationDbContext, AuthenticationDbContext>();

            // Services
            var serviceAssembly = typeof(ClientService).Assembly;
            c.RegisterManyForOpenGeneric(typeof(IMappingConfiguration<,>), serviceAssembly);
            
            serviceAssembly.ExportedTypes
                .Where(t => t.FullName.EndsWith("Service")) // Name convention of "Service".
                .Select(t => new { Implementation = t, Service = t.GetInterfaces().Single() })
                .ToList()
                .ForEach(t => c.Register(t.Service, t.Implementation));

            // MVC
            var mvcAssembly = Assembly.GetCallingAssembly();
            c.RegisterMvcControllers(mvcAssembly);
            c.RegisterMvcIntegratedFilterProvider();
            c.RegisterManyForOpenGeneric(typeof(IMappingConfiguration<,>), mvcAssembly);

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