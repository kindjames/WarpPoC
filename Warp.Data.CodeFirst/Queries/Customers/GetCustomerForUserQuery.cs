using System.Linq;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Data.Context;
using Warp.Data.Entities;

namespace Warp.Data.Queries.Customers
{
    public sealed class GetCustomerForUserQuery : IQuery<Customer>
    {
        [IdRequired]
        public int UserId { get; set; }
    }

    public sealed class GetCustomerForUserQueryHandler : IQueryHandler<GetCustomerForUserQuery, Customer>
    {
        private readonly IDomainDbContext _context;

        public GetCustomerForUserQueryHandler(IDomainDbContext context)
        {
            _context = context;
        }

        public Customer Execute(GetCustomerForUserQuery query)
        {
            var user = _context.Users
                .SingleOrDefault(u => u.UserId == query.UserId);

            return (user == null) ? null : user.Customer;
        }
    }
}