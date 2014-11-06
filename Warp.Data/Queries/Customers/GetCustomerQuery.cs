using System.Linq;
using Warp.Core.Query;
using Warp.Data.Models;

namespace Warp.Data.Queries.Customers
{
    public class GetCustomerQuery : IQuery<Customer>
    {
        public int CustomerId { get; set; }
    }

    public class GetCustomerQueryHandler : IQueryHandler<GetCustomerQuery, Customer>
    {
        private readonly IHospitalityGemDbContext _dbContext;

        public GetCustomerQueryHandler(IHospitalityGemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Customer Execute(GetCustomerQuery query)
        {
            return _dbContext.Customers
                .SingleOrDefault(b => b.CustomerID == query.CustomerId);
        }
    }
}