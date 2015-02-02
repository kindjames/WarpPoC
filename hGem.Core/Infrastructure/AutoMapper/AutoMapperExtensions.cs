using System.Collections.Generic;
using System.Linq;
using AutoMapper;

namespace hGem.Core.Infrastructure.AutoMapper
{
    public static class AutoMapperExtensions
    {
        public static IEnumerable<TTo> MapMany<TFrom, TTo>(this IMappingEngine mappingEngine, IEnumerable<TFrom> fromCollection)
        {
            return fromCollection.Select(mappingEngine.Map<TFrom, TTo>);
        }
    }
}