using SimpleInjector;
using SimpleInjector.Extensions;
using Warp.Core.Command;
using Warp.Core.Infrastructure;
using Warp.Core.Infrastructure.IoC;
using Warp.Core.Query;
using Warp.Core.Services;
using Warp.Data;
using Warp.Services;
using Warp.Services.Mappings;

namespace Warp.IoC
{
    /// <summary>
    /// Responsible for registering all DI bindings throughout the layers.
    /// </summary>
    public static class CompositionRoot
    {
        public static void RegisterBindings(Container container)
        {
            // IoC
            container.Register<IServiceLocator, ServiceLocator>();

            // Core
            container.Register<IDateTimeProvider, DateTimeProvider>();
            container.Register<IObjectMapper, ObjectMapper>();

            // Data
            var dataAssembly = typeof (IHospitalityGemDbContext).Assembly;
            container.Register<ICommandDispatcher, CommandDispatcher>();
            container.Register<IQueryDispatcher, QueryDispatcher>();
            container.RegisterManyForOpenGeneric(typeof(ICommandHandler<>), dataAssembly);
            container.RegisterManyForOpenGeneric(typeof(IQueryHandler<,>), dataAssembly);
            container.RegisterPerWebRequest<IHospitalityGemDbContext, HospitalityGemDbContext>();

            // Services
            var serviceAssembly = typeof (ClientService).Assembly;
            container.Register<IClientService, ClientService>();
            container.Register<IBrandService, BrandService>();
            container.RegisterManyForOpenGeneric(typeof(IMappingConfiguration<,>), serviceAssembly);
        }
    }
}