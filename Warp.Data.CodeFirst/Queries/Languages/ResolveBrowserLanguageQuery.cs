using System.ComponentModel.DataAnnotations;
using System.Linq;
using Warp.Core.Query;
using Warp.Data.Context;

namespace Warp.Data.Queries.Languages
{
    public sealed class ResolveBrowserLanguageQuery : IQuery<int>
    {
        [Required]
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
            return _dbContext.Languages
                .Where(lang => lang.InvariantCulture == query.InvariantCulture)
                .Select(i => i.Id)
                .SingleOrDefault();
        }
    }
}
