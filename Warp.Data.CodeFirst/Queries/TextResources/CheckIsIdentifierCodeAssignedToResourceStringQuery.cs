using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Services;
using Warp.Core.Services.Dtos.TextResources;
using Warp.Data.Context;

namespace Warp.Data.Queries.TextResources
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
