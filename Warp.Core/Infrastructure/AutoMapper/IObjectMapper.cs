using System.Collections.Generic;

namespace Warp.Core.Infrastructure.AutoMapper
{
    public interface IObjectMapper
    {
        TTo Map<TFrom, TTo>(TFrom from, bool createAnyMissingTypeMaps = true);
        IEnumerable<TTo> MapMany<TFrom, TTo>(IEnumerable<TFrom> from, bool createAnyMissingTypeMaps = true);
    }
}