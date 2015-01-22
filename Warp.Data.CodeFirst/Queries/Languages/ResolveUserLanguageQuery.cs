using System;
using System.Linq;
using FluentValidation;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.Validation;
using Warp.Data.Context;

namespace Warp.Data.Queries.Languages
{
    public sealed class ResolveUserLanguageQuery : IQuery<Guid>
    {
        public Guid Id { get; set; }
    }

    public class ResolveUserLanguageQueryValidator : AbstractValidator<ResolveUserLanguageQuery>
    {
        public ResolveUserLanguageQueryValidator()
        {
            RuleFor(q => q.Id).NotEmptyGuid();
        }
    }

    public sealed class ResolveUserLanguageQueryHandler : IQueryHandler<ResolveUserLanguageQuery, Guid>
    {
        private readonly ITextResourceDbContext _context;

        public ResolveUserLanguageQueryHandler(ITextResourceDbContext context)
        {
            _context = context;
        }

        public Guid Handle(ResolveUserLanguageQuery query)
        {
            return _context.Users
                .Where(u => u.Id == query.Id)
                .Select(u => u.DefaultLanguageId)
                .SingleOrDefault();
        }
    }
}