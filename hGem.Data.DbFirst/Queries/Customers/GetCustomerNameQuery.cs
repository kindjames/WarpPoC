using System.Linq;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Data.DbFirst.Context;

namespace Warp.Data.DbFirst.Queries.Customers
{
    public class GetCustomerNameQuery : IQuery<string>
    {
        [IdRequired]
        public int CustomerId { get; set; }
    }

    public class GetCustomerNameQueryHandler : IQueryHandler<GetCustomerNameQuery, string>
    {
        private readonly IDomainDbContext _dbContext;

        public GetCustomerNameQueryHandler(IDomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string Execute(GetCustomerNameQuery query)
        {
            return _dbContext.Customers
                .Where(b => b.CustomerId == query.CustomerId)
                .Select(c => c.Name)
                .SingleOrDefault();
        }
    }
}