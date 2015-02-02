using System.Collections.Generic;
using System.Linq;
using AutoMapper;

namespace hGem.Core.Infrastructure.AutoMapper
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

        public TTo Map<TFrom, TTo>(TFrom from, TTo to, bool createAnyMissingTypeMaps = true)
        {
            return _mappingEngine.Map(from, to, o => o.CreateMissingTypeMaps = createAnyMissingTypeMaps);
        }

        public IEnumerable<TTo> MapMany<TFrom, TTo>(IEnumerable<TFrom> from, bool createAnyMissingTypeMaps = true)
        {
            return from.Select(f => Map<TFrom, TTo>(f, createAnyMissingTypeMaps));
        }

        public TTo MapTo<TTo>(object from, bool createAnyMissingTypeMaps = true)
        {
            return _mappingEngine.Map<TTo>(from, o => o.CreateMissingTypeMaps = createAnyMissingTypeMaps);
        }

        public IEnumerable<TTo> MapToMany<TTo>(IEnumerable<object> from, bool createAnyMissingTypeMaps = true)
        {
            return from.Select(f => MapTo<TTo>(f, createAnyMissingTypeMaps));
        }
    }
}