using System.Reflection;
using System.Web.Mvc;
using AutoMapper;
using SimpleInjector;
using SimpleInjector.Extensions;
using SimpleInjector.Integration.Web.Mvc;
using Warp.Core.Command;
using Warp.Core.Infrastructure;
using Warp.Core.Infrastructure.IoC;
using Warp.Core.Query;
using Warp.Core.Services;
using Warp.Data.Context;
using Warp.Services;
using IObjectMapper = Warp.Core.Infrastructure.IObjectMapper;

namespace Warp.IoC
{
    public static class CompositionRoot
    {
        /// <summary>
        /// Responsible for registering all DI bindings within the project.
        /// </summary>
        public static IDependencyResolver GetFullyRegisteredContainer()
        {
            var container = new Container();

            // AutoMapper
            container.Register(typeof(IMappingEngine), () => Mapper.Engine);

            // IoC
            container.Register<IServiceLocator, ServiceLocator>();

            // Core
            container.Register<IDateTimeProvider, DateTimeProvider>();
            container.Register<IObjectMapper, ObjectMapper>();
            container.Register<IValidator, DataAnnotationsValidator>();

            // Data
            var dataAssembly = typeof(IHospitalityGemDbContext).Assembly;
            container.Register<ICommandDispatcher, CommandDispatcher>();
            container.Register<IQueryDispatcher, QueryDispatcher>();
            container.RegisterManyForOpenGeneric(typeof(ICommandHandler<>), dataAssembly);
            container.RegisterManyForOpenGeneric(typeof(IQueryHandler<,>), dataAssembly);
            container.RegisterManyForOpenGeneric(typeof(IMappingConfiguration<,>), dataAssembly);
            container.RegisterPerWebRequest(() => new HospitalityGemDbContextFactory().Build());

            // Services
            var serviceAssembly = typeof(ClientService).Assembly;
            container.Register<IClientService, ClientService>();
            container.Register<IBrandService, BrandService>();
            container.RegisterManyForOpenGeneric(typeof(IMappingConfiguration<,>), serviceAssembly);

            // MVC
            var mvcAssembly = Assembly.GetCallingAssembly();
            container.RegisterMvcControllers(mvcAssembly);
            container.RegisterMvcIntegratedFilterProvider();
            container.RegisterManyForOpenGeneric(typeof(IMappingConfiguration<,>), mvcAssembly);

            container.Verify();
            
            return new SimpleInjectorDependencyResolver(container);
        }
    }
}