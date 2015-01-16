using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warp.Core.Query;
using Warp.Core.Services.Dtos.TextResources;
using Warp.Data.Context;

namespace Warp.Data.Queries.TextResources
{
    public class GetAssociatedResourceIdentifierDataQuery : IQuery<ValidationResponseDto>
    {
        public string ResourceString { get; set; }
    }

    public class GetAssociatedResourceIdentifierDataQueryHandler :
        IQueryHandler<GetAssociatedResourceIdentifierDataQuery, ResourceCodeDto>
    {
        private readonly ITextResourceDbContext _context;

        public GetAssociatedResourceIdentifierDataQueryHandler(ITextResourceDbContext context)
        {
            _context = context;
        }



        public ResourceCodeDto Execute(GetAssociatedResourceIdentifierDataQuery query)
        {
            throw new NotImplementedException();
        }
    }
}
