using Warp.Core.Util;

namespace Warp.Core.Infrastructure.General
{
    public static class Extensions
    {
        public static bool IsAnonymousType(this object obj)
        {
            CheckArgument.NotNull(obj, "obj");

            return obj.GetType().Name.Contains("AnonymousType");
        }
    }
}