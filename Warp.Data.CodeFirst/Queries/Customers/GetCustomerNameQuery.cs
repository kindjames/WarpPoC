using System;
using System.Linq;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.Validation;
using Warp.Data.Context;

namespace Warp.Data.Queries.Customers
{
    public class GetCustomerNameQuery : IQuery<string>
    {
        [IdRequired]
        public Guid CustomerId { get; set; }
    }

    public class GetCustomerNameQueryHandler : IQueryHandler<GetCustomerNameQuery, string>
    {
        private readonly IDomainDbContext _dbContext;

        public GetCustomerNameQueryHandler(IDomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string Handle(GetCustomerNameQuery query)
        {
            return _dbContext.Customers
                .Where(b => b.Id == query.CustomerId)
                .Select(c => c.Name)
                .SingleOrDefault();
        }
    }
}