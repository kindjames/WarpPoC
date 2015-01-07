using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Warp.Core.Infrastructure.IoC;

namespace Warp.Core.Infrastructure.AutoMapper
{
    /// <summary>
    /// A wrapper around AutoMapper, which defaults CreateMissingTypeMaps option to true.
    /// </summary>
    public sealed class ObjectMapper : IObjectMapper
    {
        private readonly IMappingEngine _mappingEngine;
        private readonly IServiceLocator _serviceLocator;

        public ObjectMapper(IMappingEngine mappingEngine, IServiceLocator serviceLocator)
        {
            _mappingEngine = mappingEngine;
            _serviceLocator = serviceLocator;
        }

        public TTo Map<TFrom, TTo>(TFrom from, bool createAnyMissingTypeMaps = true)
        {
            return _mappingEngine.Map<TFrom, TTo>(from, o => o.CreateMissingTypeMaps = createAnyMissingTypeMaps);
        }

        public IEnumerable<TTo> MapMany<TFrom, TTo>(IEnumerable<TFrom> from, bool createAnyMissingTypeMaps = true)
        {
            return from.Select(f => Map<TFrom, TTo>(f, createAnyMissingTypeMaps));
        }
    }
}