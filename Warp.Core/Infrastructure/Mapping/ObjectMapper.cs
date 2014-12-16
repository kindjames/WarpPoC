using System;
using System.Collections.Concurrent;
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
        private static readonly ConcurrentDictionary<Tuple<Type, Type>, IMappingConfiguration<Type, Type>> MapperCache;

        private readonly IServiceLocator _serviceLocator;
        private readonly IMappingEngine _mappingEngine;

        static ObjectMapper()
        {
            MapperCache = new ConcurrentDictionary<Tuple<Type, Type>, IMappingConfiguration<Type, Type>>();
        }

        public ObjectMapper(IServiceLocator serviceLocator, IMappingEngine mappingEngine)
        {
            _serviceLocator = serviceLocator;
            _mappingEngine = mappingEngine;
        }

        public TTo Map<TFrom, TTo>(TFrom from)
        {
            // TODO: Use static concurrent dict for caching of mappings.

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