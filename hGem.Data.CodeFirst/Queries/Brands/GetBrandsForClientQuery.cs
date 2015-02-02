using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using hGem.Core.Cqrs;
using hGem.Core.Infrastructure.Validation;
using hGem.Data.Context;
using hGem.Data.Entities;

namespace hGem.Data.Queries.Brands
{
    public class GetBrandsForClientQuery : IQuery<IEnumerable<Brand>>
    {
        public Guid ClientId { get; set; }
    }

    public class GetBrandsForClientQueryValidator : AbstractValidator<GetBrandsForClientQuery>
    {
        public GetBrandsForClientQueryValidator()
        {
            RuleFor(q => q.ClientId).NotEmptyGuid();
        }
    }

    public class GetBrandsForClientQueryHandler : IQueryHandler<GetBrandsForClientQuery, IEnumerable<Brand>>
    {
        private readonly IDomainDbContext _dbContext;

        public GetBrandsForClientQueryHandler(IDomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Brand> Handle(GetBrandsForClientQuery query)
        {
            return _dbContext.Brands
                .Where(b => b.Client.Id == query.ClientId)
                .ToArray()
                .AsEnumerable();
        }
    }
}