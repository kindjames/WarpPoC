using AutoMapper;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Warp.Core.Infrastructure.IoC;

namespace Warp.Core.Infrastructure
{
    /// <summary>
    /// Implementation of IMapper, used for mapping objects.
    /// </summary>
    public class ObjectMapper : IObjectMapper
    {
        private readonly IServiceLocator _serviceLocator;
        private readonly IMappingEngine _mappingEngine;

        public ObjectMapper(IServiceLocator serviceLocator, IMappingEngine mappingEngine)
        {
            _serviceLocator = serviceLocator;
            _mappingEngine = mappingEngine;
        }

        public TTo Map<TFrom, TTo>(TFrom from)
        {
            var mapper = _serviceLocator.TryResolve<IMappingConfiguration<TFrom, TTo>>();

            if (mapper == null)
            {
                Debug.WriteLine("INFO: Could not find IMappingConfiguration<{0}, {1}> -> defaulting to AutoMapper.",
                    typeof (TFrom).Name, typeof (TTo).Name);

                return _mappingEngine.DynamicMap<TFrom, TTo>(from);
            }

            return mapper.Map(from);
        }
        
        public IEnumerable<TTo> MapMany<TFrom, TTo>(IEnumerable<TFrom> from)
        {
            return from.Select(Map<TFrom,TTo>);
        }
    }
}