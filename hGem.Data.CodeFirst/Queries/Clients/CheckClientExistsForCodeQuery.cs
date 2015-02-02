using System;
using System.Linq;
using FluentValidation;
using hGem.Core.Cqrs;
using hGem.Core.Infrastructure.Validation;
using hGem.Data.Context;

namespace hGem.Data.Queries.Clients
{
    public class CheckClientExistsForCodeQuery : IQuery<bool>
    {
        public string ClientCode { get; set; }
        public Guid CustomerId { get; set; }
    }

    public class CheckClientExistsForCodeQueryValidator : AbstractValidator<CheckClientExistsForCodeQuery>
    {
        public CheckClientExistsForCodeQueryValidator()
        {
            RuleFor(q => q.ClientCode).NotEmpty();
            RuleFor(q => q.CustomerId).NotEmptyGuid();
        }
    }

    public class CheckClientExistsForCodeQueryHandler : IQueryHandler<CheckClientExistsForCodeQuery, bool>
    {
        private readonly IDomainDbContext _dbContext;

        public CheckClientExistsForCodeQueryHandler(IDomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public bool Handle(CheckClientExistsForCodeQuery query)
        {
            return _dbContext.Clients
                .Any(c => c.Customer.Id == query.CustomerId && c.Code == query.ClientCode);
        }
    }
}