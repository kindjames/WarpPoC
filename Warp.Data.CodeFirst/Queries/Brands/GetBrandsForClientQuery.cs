using System;
using System.Collections.Generic;
using System.Linq;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.Validation;
using Warp.Data.Context;
using Warp.Data.Entities;

namespace Warp.Data.Queries.Brands
{
    public class GetBrandsForClientQuery : IQuery<IEnumerable<Brand>>
    {
        [IdRequired]
        public Guid ClientId { get; set; }
    }

    public class GetBrandsForClientQueryHandler : IQueryHandler<GetBrandsForClientQuery, IEnumerable<Brand>>
    {
        private readonly IDomainDbContext _dbContext;

        public GetBrandsForClientQueryHandler(IDomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Brand> Handle(GetBrandsForClientQuery query)
        {
            return _dbContext.Brands
                .Where(b => b.Client.Id == query.ClientId)
                .ToArray()
                .AsEnumerable();
        }
    }
}