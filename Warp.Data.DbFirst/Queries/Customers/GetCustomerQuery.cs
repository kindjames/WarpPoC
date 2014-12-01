using System.Linq;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Data.DbFirst.Context;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Queries.Customers
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
                .SingleOrDefault(b => b.CustomerId == query.CustomerId);
        }
    }
}