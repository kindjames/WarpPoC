using System;
using System.Linq;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.Validation;
using Warp.Data.Context;
using Warp.Data.Entities;

namespace Warp.Data.Queries.Customers
{
    public class GetCustomerQuery : IQuery<Customer>
    {
        [IdRequired]
        public Guid CustomerId { get; set; }
    }

    public class GetCustomerQueryHandler : IQueryHandler<GetCustomerQuery, Customer>
    {
        private readonly IDomainDbContext _dbContext;

        public GetCustomerQueryHandler(IDomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Customer Handle(GetCustomerQuery query)
        {
            return _dbContext.Customers
                .SingleOrDefault(b => b.Id == query.CustomerId);
        }
    }
}