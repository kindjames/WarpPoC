using System;
using System.Linq;
using AutoMapper;
using Warp.Core.Infrastructure.AutoMapper;

namespace Warp.WebUI
{
    public partial class Startup
    {
        public void ConfigureAutoMapper(IConfiguration configuration)
        {
            var mappingConfigurations = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes()
                    .Where(typeof (IMappingConfiguration).IsAssignableFrom)
                    .Where(t => !t.IsInterface)
                    .Select(Activator.CreateInstance)
                    .OfType<IMappingConfiguration>()
                );

            foreach (var mappingConfiguration in mappingConfigurations)
            {
                mappingConfiguration.Configure(configuration);
            }
        }
    }
}