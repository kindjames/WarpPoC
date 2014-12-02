using System.Linq;
using Warp.Core.Query;
using Warp.Core.Util;
using Warp.Data.Context;

namespace Warp.Data.Queries.TextResources
{
    public sealed class ResolveBrowserLanguageQuery : IQuery<int>
    {
        public string InvariantCulture { get; set; }
    }

    public sealed class ResolveBrowserLanguageQueryHandler : IQueryHandler<ResolveBrowserLanguageQuery, int>
    {
        private readonly ITextResourceDbContext _dbContext;

        public ResolveBrowserLanguageQueryHandler(ITextResourceDbContext context)
        {
            _dbContext = context;
        }

        public int Execute(ResolveBrowserLanguageQuery query)
        {
            CheckArgument.NotEmpty(query.InvariantCulture, "ResolveBrowserLanguageQuery");

            return _dbContext.Languages
                .Where(lang => lang.InvariantCulture == query.InvariantCulture)
                .Select(i => i.LanguageId)
                .SingleOrDefault();
        }
    }
}
