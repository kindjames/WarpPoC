using System;
using System.Linq;
using Warp.Data.Entities;

namespace Warp.Data.Migrations.DataSeed
{
    public class CustomerDataFactory : IDataFactory
    {
        public int Order { get { return 1; } }

        public void AddDataToContext(InternalMigrationsInitializationContext context)
        {
        }
    }
}