using System;
using Ninject;
using Warp.Core;
using Warp.Core.Infrastructure;

namespace Warp.Console
{
    public class NinjectResolver : IDependencyResolver
    {
        private readonly IKernel _kernel;

        public NinjectResolver(IKernel kernel)
        {
            _kernel = kernel;
        }
        
        public void Release(object obj)
        {
            _kernel.Release(obj);
        }

        public object TryResolve(Type type)
        {
            return _kernel.TryGet(type);
        }

        public object Resolve(Type type)
        {
            return _kernel.Get(type);
        }
    }
}