using System.Linq;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Data.Context;

namespace Warp.Data.Queries.TextResources
{
    public sealed class GetTextResourceCodeQuery : IQuery<string>
    {
        [IdRequired]
        public int TextResourceCodeId { get; set; }
    }

    public sealed class GetTextResourceCodeQueryHandler : IQueryHandler<GetTextResourceCodeQuery, string>
    {
        private readonly ITextResourceDbContext _context;

        public GetTextResourceCodeQueryHandler(ITextResourceDbContext context)
        {
            _context = context;
        }

        public string Execute(GetTextResourceCodeQuery query)
        {
            return _context.TextResourceCodes
                .Where(trc => trc.TextResourceIdentifierId == query.TextResourceCodeId)
                .Select(trc => trc.TextResourceCode)
                .SingleOrDefault();
        }
    }
}
