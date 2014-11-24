using System;
using AutoMapper;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using SimpleInjector;
using SimpleInjector.Advanced;
using SimpleInjector.Advanced.Extensions;
using SimpleInjector.Extensions;
using SimpleInjector.Integration.Web.Mvc;
using System.Diagnostics;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Warp.Core.Authentication;
using Warp.Core.Command;
using Warp.Core.Infrastructure.IoC;
using Warp.Core.Infrastructure.Mapping;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Core.Services;
using Warp.Core.Util;
using Warp.Data.Context;
using Warp.Data.Identity;
using Warp.Data.Infrastructure;
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

            // Core
            c.Register<IDateTimeProvider, DateTimeProvider>();
            c.Register<IObjectMapper, ObjectMapper>();
            c.Register<IValidator, DataAnnotationsValidator>();

            // Data
            var dataAssembly = typeof(IDomainDbContext).Assembly;
            c.Register<ICommandDispatcher, CommandDispatcher>();
            c.Register<IQueryDispatcher, QueryDispatcher>();
            c.Register<IEntityMappingsResolver, EntityMappingsResolver>();
            c.RegisterManyForOpenGeneric(typeof(ICommandHandler<>), dataAssembly);
            c.RegisterManyForOpenGeneric(typeof(IQueryHandler<,>), dataAssembly);
            c.RegisterManyForOpenGeneric(typeof(IMappingConfiguration<,>), dataAssembly);
            c.RegisterPerWebRequest<IDomainDbContext, DomainDbContext>();
            c.RegisterPerWebRequest<IAuthenticationDbContext, AuthenticationDbContext>();
            c.RegisterInitializer<IApplicationDbContext>(d => d.Database.Log = s => Debug.Write(s));

            // Services
            var serviceAssembly = typeof(ClientService).Assembly;
            c.Register<IClientService, ClientService>();
            c.Register<IBrandService, BrandService>();
            c.RegisterManyForOpenGeneric(typeof(IMappingConfiguration<,>), serviceAssembly);

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
            c.Register(() => new UserManager<ApplicationUser, int>(new ApplicationUserStore(c.GetInstance<IAuthenticationDbContext>(), c.GetInstance<IDateTimeProvider>()))
            {
                PasswordHasher = new PasswordHasher()
            });
            
            c.RegisterPerWebRequest(() =>
            {
                try
                {
                    return c.GetInstance<HttpContextBase>()
                        .GetOwinContext()
                        .Authentication;
                }
                catch (InvalidOperationException)
                {
                    if (c.IsVerifying())
                    {
                        return new FakeAuthenticationManager();
                    }
                    throw;
                }
            });

            c.Verify();
            
            return new SimpleInjectorDependencyResolver(c);
        }
    }
}