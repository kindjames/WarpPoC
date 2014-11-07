using System.Collections.Generic;
using System.Linq;
using Warp.Core.Exceptions;
using Warp.Core.Infrastructure.IoC;

namespace Warp.Core.Infrastructure
{
    /// <summary>
    /// Implementation of IMapper, used for mapping objects.
    /// </summary>
    public class ObjectMapper : IObjectMapper
    {
        private readonly IServiceLocator _serviceLocator;

        public ObjectMapper(IServiceLocator serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

        public TTo Map<TFrom, TTo>(TFrom from)
        {
            var mapper = _serviceLocator.TryResolve<IMappingConfiguration<TFrom, TTo>>();

            if (mapper == null)
            {
                throw new ObjectMappingConfigurationNotFound<TFrom, TTo>();
            }

            return mapper.Map(from);
        }
        
        public IEnumerable<TTo> MapMany<TFrom, TTo>(IEnumerable<TFrom> from)
        {
            var mapper = _serviceLocator.TryResolve<IMappingConfiguration<TFrom, TTo>>();

            if (mapper == null)
            {
                throw new ObjectMappingConfigurationNotFound<TFrom, TTo>();
            }

            return from.Select(mapper.Map);
        }
    }
}