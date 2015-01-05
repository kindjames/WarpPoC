using AutoMapper;

namespace Warp.Core.Infrastructure.AutoMapper
{
    /// <summary>
    /// Used to define any special AutoMapper object-mapping configuration.
    /// </summary>
    public interface IMappingConfiguration
    {
        void Configure(IConfiguration configuration);
    }
}