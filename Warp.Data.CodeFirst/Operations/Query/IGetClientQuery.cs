using System;
using Warp.Core.Operations;
using Warp.Data.Entities;

namespace Warp.Data.Operations.Query
{
    public interface IGetClientQuery : IQuery<Client>
    {
        Guid ClientId { set; }
    }
}