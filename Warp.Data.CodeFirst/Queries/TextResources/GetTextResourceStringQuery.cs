using System;
using System.Linq;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.Validation;
using Warp.Data.Context;

namespace Warp.Data.Queries.TextResources
{
    public sealed class GetTextResourceStringQuery : IQuery<string>
    {
        [IdRequired]
        public Guid TextResourceIdentifierId { get; set; }
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
                .Where(trs => trs.TextResourceIdentifier.Id == query.TextResourceIdentifierId)
                .Select(trs => trs.ResourceString)
                .SingleOrDefault();
        }
    }
}