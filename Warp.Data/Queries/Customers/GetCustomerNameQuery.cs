using System.Linq;
using Warp.Core.Query;
using Warp.Data.Context;

namespace Warp.Data.Queries.Customers
{
    public class GetCustomerNameQuery : IQuery<string>
    {
        public int CustomerId { get; set; }
    }

    public class GetCustomerNameQueryHandler : IQueryHandler<GetCustomerNameQuery, string>
    {
        private readonly IHospitalityGemDbContext _dbContext;

        public GetCustomerNameQueryHandler(IHospitalityGemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string Execute(GetCustomerNameQuery query)
        {
            return _dbContext.Customers
                .Where(b => b.CustomerID == query.CustomerId)
                .Select(c => c.Name)
                .SingleOrDefault();
        }
    }
}