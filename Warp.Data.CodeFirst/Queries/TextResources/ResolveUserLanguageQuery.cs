using System;
using System.Linq;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.Validation;
using Warp.Data.Context;

namespace Warp.Data.Queries.TextResources
{
    public sealed class ResolveUserLanguageQuery : IQuery<Guid>
    {
        [IdRequired]
        public Guid UserId { get; set; }
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
                .Where(u => u.Id == query.UserId)
                .Select(u => u.DefaultLanguageId)
                .SingleOrDefault();
        }
    }
}