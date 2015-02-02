using System;

namespace hGem.Core.Infrastructure.General
{
    public interface IUniqueIdentifierGenerator
    {
        Guid GenerateNewId();
    }
}