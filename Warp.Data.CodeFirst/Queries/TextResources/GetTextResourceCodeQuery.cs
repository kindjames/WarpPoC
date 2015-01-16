using System;
using System.Linq;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.Validation;
using Warp.Data.Context;

namespace Warp.Data.Queries.TextResources
{
    public sealed class GetTextResourceCodeQuery : IQuery<string>
    {
        [IdRequired]
        public Guid TextResourceCodeId { get; set; }
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
            return _context.TextResourceCodes
                .Where(trc => trc.Id == query.TextResourceCodeId)
                .Select(trc => trc.TextResourceCode)
                .SingleOrDefault();
        }
    }
}