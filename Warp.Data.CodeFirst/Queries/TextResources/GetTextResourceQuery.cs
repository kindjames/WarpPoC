using System.Linq;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Data.Context;
using Warp.Data.Entities;

namespace Warp.Data.Queries.TextResources
{
    public sealed class GetTextResourceQuery : IQuery<string>
    {
        [IdRequired]
        public int TextResourceCodeId { get; set; }
    }

    public sealed class GetTextResourceQueryHandler : IQueryHandler<GetTextResourceQuery, string>
    {
        readonly ITextResourceDbContext _context;

        public GetTextResourceQueryHandler(ITextResourceDbContext context)
        {
            _context = context;
        }

        public string Execute(GetTextResourceQuery query)
        {
            return Enumerable.SingleOrDefault(_context.TextResources
                .Where(t => t.TextResourceCodeId == query.TextResourceCodeId)
                .Select(t => t.ResourceString));
        }
    }
}