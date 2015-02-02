using System;
using System.Linq;
using FluentValidation;
using hGem.Core.Cqrs;
using hGem.Core.Infrastructure.Validation;
using hGem.Data.Context;

namespace hGem.Data.Queries.Customers
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