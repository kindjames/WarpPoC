using System.Collections.Generic;
using System.Linq;
using Warp.Core.Query;
using Warp.Data.Context;
using Warp.Data.Entities;

namespace Warp.Data.Queries.Brands
{
    public class GetBrandsForClientQuery : IQuery<IEnumerable<Brand>>
    {
        public int ClientId { get; set; }
    }

    public class GetBrandsForClientQueryHandler : IQueryHandler<GetBrandsForClientQuery, IEnumerable<Brand>>
    {
        private readonly IHospitalityGemDbContext _dbContext;

        public GetBrandsForClientQueryHandler(IHospitalityGemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Brand> Execute(GetBrandsForClientQuery query)
        {
            return _dbContext.Brands
                .Where(b => b.ClientID == query.ClientId)
                .ToArray()
                .AsEnumerable();
        }
    }
}