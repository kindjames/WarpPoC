using System;
using Warp.Core.Infrastructure;

namespace Warp.Core.Exceptions
{
    public class ObjectMappingConfigurationNotFound<TFrom, TTo> : Exception
    {
        public ObjectMappingConfigurationNotFound()
            : base(String.Concat("Unable to locate object mapping configuration - ",
            typeof (IMappingConfiguration<,>).Name, "<", typeof (TFrom).Name, ", ", typeof (TTo).Name, ">. Ensure one has been created and registered with DI Container."))
        {
        }
    }
}