using System;
using System.Linq;
using FluentValidation;
using hGem.Core.Cqrs;
using hGem.Core.Infrastructure.Validation;
using hGem.Data.Context;
using hGem.Data.Entities;

namespace hGem.Data.Queries.Customers
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