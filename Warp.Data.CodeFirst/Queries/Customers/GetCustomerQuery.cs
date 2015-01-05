using System.Linq;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Data.Context;
using Warp.Data.Entities;

namespace Warp.Data.Queries.Customers
{
    public class GetCustomerQuery : IQuery<Customer>
    {
        [IdRequired]
        public int CustomerId { get; set; }
    }

    public class GetCustomerQueryHandler : IQueryHandler<GetCustomerQuery, Customer>
    {
        private readonly IDomainDbContext _dbContext;

        public GetCustomerQueryHandler(IDomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Customer Execute(GetCustomerQuery query)
        {
            return _dbContext.Customers
                .SingleOrDefault(b => b.Id == query.CustomerId);
        }
    }
}