using System.Linq;
using Warp.Core.Query;
using Warp.Data.Context;

namespace Warp.Data.Queries.Languages
{
    public sealed class GetLanguageIdByInvariantCultureQuery : IQuery<int>
    {
        public string InvariantCulture { get; set; }
    }

    public sealed class GetLanguageIdByInvariantCultureQueryHandler : IQueryHandler<GetLanguageIdByInvariantCultureQuery, int>
    {
        private readonly ITextResourceDbContext _dbContext;

        public GetLanguageIdByInvariantCultureQueryHandler(ITextResourceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Execute(GetLanguageIdByInvariantCultureQuery query)
        {
            return _dbContext.Languages
                .Where(l => l.InvariantCulture == query.InvariantCulture)
                .Select(l => l.Id)
                .SingleOrDefault();
        }
    }
}