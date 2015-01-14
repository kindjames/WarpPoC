using System.Collections.Generic;

namespace Warp.Core.Infrastructure.AutoMapper
{
    public interface IObjectMapper
    {
        TTo Map<TFrom, TTo>(TFrom from, bool createAnyMissingTypeMaps = true);
        TTo Map<TFrom, TTo>(TFrom from, TTo to, bool createAnyMissingTypeMaps = true);

        TTo MapTo<TTo>(object from, bool createAnyMissingTypeMaps = true);

        IEnumerable<TTo> MapMany<TFrom, TTo>(IEnumerable<TFrom> from, bool createAnyMissingTypeMaps = true);
        IEnumerable<TTo> MapToMany<TTo>(IEnumerable<object> from, bool createAnyMissingTypeMaps = true);
    }
}