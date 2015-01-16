using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warp.Core.Query;
using Warp.Core.Services.Dtos.TextResources;

namespace Warp.Data.Queries.TextResources
{
    public class GetAssociatedResourceStringDataQuery : IQuery<ValidationResponseDto>
    {
        public string ResourceIdentifierCode { get; set; }
    }


}
