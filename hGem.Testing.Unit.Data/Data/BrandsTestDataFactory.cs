using System;
using System.Collections.Generic;
using hGem.Data.Entities;
using hGem.Testing.Unit.Data.Util;

namespace hGem.Testing.Unit.Data.Data
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