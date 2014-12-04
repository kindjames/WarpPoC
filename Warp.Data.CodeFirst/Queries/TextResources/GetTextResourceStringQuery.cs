using System.Linq;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Data.Context;

namespace Warp.Data.Queries.TextResources
{
    public sealed class GetTextResourceStringQuery : IQuery<string>
    {
        [IdRequired]
        public int TextResourceCodeId { get; set; }
    }

    public sealed class GetTextResourceStringQueryHandler : IQueryHandler<GetTextResourceStringQuery, string>
    {
        readonly ITextResourceDbContext _context;

        public GetTextResourceStringQueryHandler(ITextResourceDbContext context)
        {
            _context = context;
        }

        public string Execute(GetTextResourceStringQuery query)
        {
            return _context.TextResources
                .Where(trs => trs.TextResourceIdentifier.TextResourceIdentifierId == query.TextResourceCodeId)
                .Select(trs => trs.ResourceString)
                .SingleOrDefault();
        }
    }
}