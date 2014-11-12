using System;
using System.Linq;
using Warp.Core.Query;
using Warp.Core.Validation;
using Warp.Data.Context;
using System.ComponentModel.DataAnnotations;

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
        private readonly IHospitalityGemDbContext _dbContext;

        public CheckClientExistsForCodeQueryHandler(IHospitalityGemDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Execute(CheckClientExistsForCodeQuery query)
        {
            return _dbContext.Clients
                .Any(c => c.CustomerID == query.CustomerId && c.Code == query.ClientCode);
        }
    }
}