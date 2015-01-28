using System;
using System.Collections.Generic;
using Warp.Data.Entities;
using Warp.Testing.Unit.Data.Util;

namespace Warp.Testing.Unit.Data.Data
{
    public class BrandsTestDataFactory : ITestDataFactory<Brand>
    {
        public IEnumerable<Brand> Build()
        {
            return new[]
            {
                new Brand {Client = new Client { Id = Guid.NewGuid()}},
                new Brand {Client = new Client { Id = Guid.NewGuid()}},
                new Brand {Client = new Client { Id = Guid.NewGuid()}},
                new Brand {Client = new Client { Id = Guid.NewGuid()}},
                new Brand {Client = new Client { Id = Guid.NewGuid()}},
                new Brand {Client = new Client { Id = Guid.NewGuid()}},
                new Brand {Client = new Client { Id = Guid.NewGuid()}}
            };
        }
    }
}