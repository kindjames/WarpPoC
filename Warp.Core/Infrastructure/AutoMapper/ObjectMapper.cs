using System.Collections.Generic;
using System.Linq;
using AutoMapper;

namespace Warp.Core.Infrastructure.AutoMapper
{
    /// <summary>
    /// A wrapper around AutoMapper, which defaults CreateMissingTypeMaps option to true.
    /// </summary>
    public sealed class ObjectMapper : IObjectMapper
    {
        private readonly IMappingEngine _mappingEngine;

        public ObjectMapper(IMappingEngine mappingEngine)
        {
            _mappingEngine = mappingEngine;
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