using System.ComponentModel.DataAnnotations;
using System.Linq;
using hGem.Core.Cqrs;
using hGem.Data.Context;

namespace hGem.Data.Queries.TextResources
{
    public class DuplicateResourceCodeExistsQuery : IQuery<bool>
    {
        [Required]
        public string ResourceCode { get; set; }
    }

    public class DuplicateResourceCodeExistsQueryHandler : IQueryHandler<DuplicateResourceCodeExistsQuery, bool>
    {
        private readonly ITextResourceDbContext _dbContext;

        public DuplicateResourceCodeExistsQueryHandler(ITextResourceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Handle(DuplicateResourceCodeExistsQuery query)
        {
            return _dbContext.TextResourceIdentifiers
                .Any(trc => trc.TextResourceCode == query.ResourceCode);
        }
    }
}