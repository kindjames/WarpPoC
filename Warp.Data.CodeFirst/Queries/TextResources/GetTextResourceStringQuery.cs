using System.Linq;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Data.Context;

namespace Warp.Data.Queries.TextResources
{
    public sealed class GetTextResourceStringQuery : IQuery<string>
    {
        [IdRequired]
        public int TextResourceIdentifierId { get; set; }

        [IdRequired]
        public int LanguageId { get; set; }
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
                .Where(trs => trs.TextResourceIdentifier.Id == query.TextResourceIdentifierId && trs.LanguageId == query.LanguageId)
                .Select(trs => trs.ResourceString)
                .SingleOrDefault();
        }
    }
}