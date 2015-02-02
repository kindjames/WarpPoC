using System;
using System.Linq;
using FluentValidation;
using hGem.Core.Cqrs;
using hGem.Core.Infrastructure.Validation;
using hGem.Data.Context;

namespace hGem.Data.Queries.TextResources
{
    public sealed class GetTextResourceStringQuery : IQuery<string>
    {
        public Guid TextResourceIdentifierId { get; set; }

        public Guid LanguageId { get; set; }
    }

    public sealed class GetTextResourceStringQueryValidator : AbstractValidator<GetTextResourceStringQuery>
    {
        public GetTextResourceStringQueryValidator()
        {
            RuleFor(q => q.TextResourceIdentifierId).NotEmptyGuid();
            RuleFor(q => q.LanguageId).NotEmptyGuid();
        }
    }

    public sealed class GetTextResourceStringQueryHandler : IQueryHandler<GetTextResourceStringQuery, string>
    {
        readonly ITextResourceDbContext _context;

        public GetTextResourceStringQueryHandler(ITextResourceDbContext context)
        {
            _context = context;
        }

        public string Handle(GetTextResourceStringQuery query)
        {
            return _context.TextResources
                .Where(trs => trs.TextResourceIdentifier.Id == query.TextResourceIdentifierId && trs.LanguageId == query.LanguageId)
                .Select(trs => trs.ResourceString)
                .SingleOrDefault();
        }
    }
}