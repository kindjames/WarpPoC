using AutoMapper;

namespace hGem.Core.Infrastructure.AutoMapper
{
    /// <summary>
    /// Used to define any special AutoMapper object-mapping configuration.
    /// </summary>
    public interface IMappingConfiguration
    {
        void Configure(IConfiguration configuration);
    }
}