using System;

namespace Warp.Core.Infrastructure
{
    public interface IDependencyResolver
    {
        void Release(object obj);
        object TryResolve(Type type);
    }
}