using System;
using System.Linq;
using FluentValidation;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.Validation;
using Warp.Data.Context;
using Warp.Data.Entities;

namespace Warp.Data.Queries.Customers
{
    public sealed class GetCustomerForUserQuery : IQuery<Customer>
    {
        public Guid UserId { get; set; }
    }

    public class GetCustomerForUserQueryValidator : AbstractValidator<GetCustomerForUserQuery>
    {
        public GetCustomerForUserQueryValidator()
        {
            RuleFor(q => q.UserId).NotEmptyGuid();
        }
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