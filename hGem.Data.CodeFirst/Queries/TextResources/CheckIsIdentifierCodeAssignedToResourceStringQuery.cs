using System;
using FluentValidation;
using hGem.Core.Cqrs;
using hGem.Core.Infrastructure.Validation;
using hGem.Core.Services.Dtos.TextResources;
using hGem.Data.Context;

namespace hGem.Data.Queries.TextResources
{
    public sealed class CheckIsIdentifierCodeAssignedToResourceStringQuery : IQuery<TextResourceDetailDto>
    {
        public Guid ResourceIdentifierId { get; set; }
    }

    public class CheckIsIdentifierCodeAssignedToResourceStringQueryValidator :
        AbstractValidator<CheckIsIdentifierCodeAssignedToResourceStringQuery>
    {
        public CheckIsIdentifierCodeAssignedToResourceStringQueryValidator()
        {
            RuleFor(q => q.ResourceIdentifierId).NotEmptyGuid();
        }
    }

    public sealed class CheckIsIdentifierCodeAssignedToResourceStringQueryHandler : 
        IQueryHandler<CheckIsIdentifierCodeAssignedToResourceStringQuery, TextResourceDetailDto>
    {
        private readonly ITextResourceDbContext _dbContext;

        public CheckIsIdentifierCodeAssignedToResourceStringQueryHandler(ITextResourceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TextResourceDetailDto Handle(CheckIsIdentifierCodeAssignedToResourceStringQuery query)
        {
            throw new NotImplementedException();
        }
    }
}
