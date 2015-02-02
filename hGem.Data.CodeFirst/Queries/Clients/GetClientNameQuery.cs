using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using hGem.Core.Cqrs;
using hGem.Data.Context;

namespace hGem.Data.Queries.Clients
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
