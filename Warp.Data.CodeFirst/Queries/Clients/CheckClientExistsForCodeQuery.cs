using System.ComponentModel.DataAnnotations;
using System.Linq;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Data.Context;

namespace Warp.Data.Queries.Clients
{
    public class CheckClientExistsForCodeQuery : IQuery<bool>
    {
        [Required]
        public string ClientCode { get; set; }

        [IdRequired]
        public int CustomerId { get; set; }
    }

    public class CheckClientExistsForCodeQueryHandler : IQueryHandler<CheckClientExistsForCodeQuery, bool>
    {
        private readonly IDomainDbContext _dbContext;

        public CheckClientExistsForCodeQueryHandler(IDomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Execute(CheckClientExistsForCodeQuery query)
        {
            return _dbContext.Clients
                .Any(c => c.Customer.CustomerId == query.CustomerId && c.Code == query.ClientCode);
        }
    }
}