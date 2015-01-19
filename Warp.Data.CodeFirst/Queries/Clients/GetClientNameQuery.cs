using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warp.Core.Cqrs;
using Warp.Data.Context;

namespace Warp.Data.Queries.Clients
{
    public class GetClientNameQuery : IQuery<string>
    {
        [Required]
        public Guid ClientId { get; set; }
    }

    public class GetClientNameQueryHandler : IQueryHandler<GetClientNameQuery, string>
    {
        private readonly IDomainDbContext _dbContext;

        public GetClientNameQueryHandler(IDomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Query on ClientId returns Client name
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public string Handle(GetClientNameQuery query)
        {
            return _dbContext.Clients
                .SingleOrDefault(c => c.Id == query.ClientId).Name;
        }
    }
}
