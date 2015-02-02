using System;
using System.Linq;
using FluentValidation;
using hGem.Core.Cqrs;
using hGem.Core.Infrastructure.Validation;
using hGem.Data.Context;

namespace hGem.Data.Queries.TextResources
{
    public sealed class GetTextResourceQuery : IQuery<string>
    {
        public Guid TextResourceIdentifierId { get; set; }
    }

    public class GetTextResourceQueryValidator : AbstractValidator<GetTextResourceQuery>
    {
        public GetTextResourceQueryValidator()
        {
            RuleFor(q => q.TextResourceIdentifierId).NotEmptyGuid();
        }
    }

    public sealed class GetTextResourceQueryHandler : IQueryHandler<GetTextResourceQuery, string>
    {
        readonly ITextResourceDbContext _context;

        public GetTextResourceQueryHandler(ITextResourceDbContext context)
        {
            _context = context;
        }

        public string Handle(GetTextResourceQuery query)
        {
            // TODO: JK -> PG Does this need to filter on language too?
            return _context.TextResources
                    .Where(t => t.TextResourceIdentifier.Id == query.TextResourceIdentifierId)
                    .Select(t => t.ResourceString)
                    .SingleOrDefault();
        }
    }
}