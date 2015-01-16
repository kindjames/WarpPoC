using System.ComponentModel.DataAnnotations;
using System.Linq;
using Warp.Core.Cqrs;
using Warp.Data.Context;

namespace Warp.Data.Queries.TextResources
{
    public class ValidateResourceStringQuery : IQuery<bool>
    {
        [Required]
        public string ResourceString { get; set; }

        [Required]
        public int UserLanguageId { get; set; }
    }

    public class ValidateResourceStringQueryHandler : IQueryHandler<ValidateResourceStringQuery, bool>
    {
        private readonly ITextResourceDbContext _dbContext;

        public ValidateResourceStringQueryHandler(ITextResourceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Handle(DuplicateResourceStringExistsQuery query)
        {
            return _dbContext.TextResources
                .Any(tr => tr.ResourceString == query.ResourceString && tr.LanguageId == query.UserLanguageId);
        }
    }
}