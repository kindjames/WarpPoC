using System;
using System.Linq;
using FluentValidation;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.Validation;
using Warp.Data.Context;

namespace Warp.Data.Queries.TextResources
{
    public sealed class GetTextResourceCodeQuery : IQuery<string>
    {
        public Guid TextResourceCodeId { get; set; }
    }

    public class GetTextResourceCodeQueryValidator : AbstractValidator<GetTextResourceCodeQuery>
    {
        public GetTextResourceCodeQueryValidator()
        {
            RuleFor(q => q.TextResourceCodeId).NotEmptyGuid();
        }
    }

    public sealed class GetTextResourceCodeQueryHandler : IQueryHandler<GetTextResourceCodeQuery, string>
    {
        private readonly ITextResourceDbContext _context;

        public GetTextResourceCodeQueryHandler(ITextResourceDbContext context)
        {
            _context = context;
        }

        public string Handle(GetTextResourceCodeQuery query)
        {
            return _context.TextResourceIdentifiers
                .Where(trc => trc.Id == query.TextResourceCodeId)
                .Select(trc => trc.ResourceIdentifierCode)
                .SingleOrDefault();
        }
    }
}
