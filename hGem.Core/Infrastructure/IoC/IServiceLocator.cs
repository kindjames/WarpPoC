using System;

namespace hGem.Core.Infrastructure.IoC
{
    public interface IServiceLocator
    {
        object TryResolve(Type type);

        TService TryResolve<TService>()
            where TService : class;
    }
}