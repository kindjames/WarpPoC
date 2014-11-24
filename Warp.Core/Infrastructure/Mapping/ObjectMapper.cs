using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using AutoMapper;
using Warp.Core.Infrastructure.IoC;

namespace Warp.Core.Infrastructure.Mapping
{
    /// <summary>
    /// Used to map objects. Uses IMappingConfiguration for custom mappings, otherwise, falls back on AutoMapper.
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
            // Attempts to find a custom IMappingConfiguration.
            var mapper = _serviceLocator.TryResolve<IMappingConfiguration<TFrom, TTo>>();

            if (mapper != null)
            {
                return mapper.Map(from);
            }

            // A warning to the developer... do you hear me?!
            Debug.WriteLine("INFO: Could not find IMappingConfiguration<{0}, {1}> -> defaulting to AutoMapper.",
                typeof (TFrom).Name, typeof (TTo).Name);
            
            // Custom mapping not found, use AutoMapper.
            return _mappingEngine.DynamicMap<TFrom, TTo>(from);
        }
        
        public IEnumerable<TTo> MapMany<TFrom, TTo>(IEnumerable<TFrom> from)
        {
            return from.Select(Map<TFrom,TTo>);
        }
    }
}