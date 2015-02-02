using AutoMapper;
using hGem.Core.Infrastructure.AutoMapper;

namespace hGem.Data
{
    public sealed class MappingConfiguration : IMappingConfiguration
    {
        public void Configure(IConfiguration configuration)
        {
            //configuration.CreateMap<CreateClientCommand, Client>();
        }
    }
}