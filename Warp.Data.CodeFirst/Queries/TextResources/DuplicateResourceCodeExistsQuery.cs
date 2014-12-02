using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warp.Core.Query;
using Warp.Data.Context;

namespace Warp.Data.Queries.TextResources
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

        public bool Execute(DuplicateResourceCodeExistsQuery query)
        {
            return _dbContext.TextResourceCodes
                .Any(trc => trc.ResourceCode == query.ResourceCode);
        }
    }
}
