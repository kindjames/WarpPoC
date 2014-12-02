using System.Linq;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Data.Context;
using Warp.Data.Entities;

namespace Warp.Data.Queries.TextResources
{
    public sealed class GetTextResourceQuery : IQuery<TextResource>
    {
        [IdRequired]
        public int TextResourceCodeId { get; set; }
    }

    public sealed class GetTextResourceQueryHandler : IQueryHandler<GetTextResourceQuery, TextResource>
    {
        readonly ITextResourceDbContext _context;

        public GetTextResourceQueryHandler(ITextResourceDbContext context)
        {
            _context = context;
        }

        public TextResource Execute(GetTextResourceQuery query)
        {
            return _context.TextResources.SingleOrDefault(trc => trc.TextResourceCodeId == query.TextResourceCodeId);
        }
    }
}