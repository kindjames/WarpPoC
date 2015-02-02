using System.Collections.Generic;
using System.Linq;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Data.DbFirst.Context;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Queries.Brands
{
    public class GetBrandsForClientQuery : IQuery<IEnumerable<Brand>>
    {
        [IdRequired]
        public int ClientId { get; set; }
    }

    public class GetBrandsForClientQueryHandler : IQueryHandler<GetBrandsForClientQuery, IEnumerable<Brand>>
    {
        private readonly IDomainDbContext _dbContext;

        public GetBrandsForClientQueryHandler(IDomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Brand> Execute(GetBrandsForClientQuery query)
        {
            return _dbContext.Brands
                .Where(b => b.ClientId == query.ClientId)
                .ToArray()
                .AsEnumerable();
        }
    }
}