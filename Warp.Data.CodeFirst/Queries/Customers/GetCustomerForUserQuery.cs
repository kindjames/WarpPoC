using System;
using System.Linq;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.Validation;
using Warp.Data.Context;
using Warp.Data.Entities;

namespace Warp.Data.Queries.Customers
{
    public sealed class GetCustomerForUserQuery : IQuery<Customer>
    {
        [IdRequired]
        public Guid UserId { get; set; }
    }

    public sealed class GetCustomerForUserQueryHandler : IQueryHandler<GetCustomerForUserQuery, Customer>
    {
        private readonly IDomainDbContext _context;

        public GetCustomerForUserQueryHandler(IDomainDbContext context)
        {
            _context = context;
        }

        public Customer Handle(GetCustomerForUserQuery query)
        {
            var user = _context.Users
                .SingleOrDefault(u => u.Id == query.UserId);

            return (user == null) ? null : user.Customer;
        }
    }
}