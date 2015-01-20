using System;

namespace Warp.Core.Infrastructure.General
{
    public interface IUniqueIdentifierGenerator
    {
        Guid GenerateNewId();
    }
}