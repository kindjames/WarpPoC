using System;
using System.Linq;
using FluentValidation;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.Validation;
using Warp.Data.Context;

namespace Warp.Data.Queries.Customers
{
    public class GetCustomerNameQuery : IQuery<string>
    {
        public Guid CustomerId { get; set; }
    }

    public class GetCustomerNameQueryValidator : AbstractValidator<GetCustomerNameQuery>
    {
        public GetCustomerNameQueryValidator()
        {
            RuleFor(q => q.CustomerId).NotEmptyGuid();
        }
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