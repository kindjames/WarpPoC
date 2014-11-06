using AutoMapper;
using Warp.Core.Infrastructure;

namespace Warp.Console
{
    /// <summary>
    /// Implementation of IMapper, used for mapping objects.
    /// </summary>
    public class ObjectMapper : IMapper
    {
        private readonly IMappingEngine _mappingEngine;

        public ObjectMapper(IMappingEngine mappingEngine)
        {
            _mappingEngine = mappingEngine;
        }

        public TTo Map<TFrom, TTo>(TFrom from)
        {
            return _mappingEngine.Map<TFrom, TTo>(from);
        }

        public TTo Map<TTo>(object from)
        {
            return _mappingEngine.Map<TTo>(from);
        }
    }
}