using AutoMapper;
using Warp.Core.Infrastructure.AutoMapper;

namespace Warp.Data
{
    public sealed class MappingConfiguration : IMappingConfiguration
    {
        public void Configure(IConfiguration configuration)
        {
            //configuration.CreateMap<SaveNewClientCommand, Client>();
        }
    }
}