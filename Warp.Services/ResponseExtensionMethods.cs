using Warp.Core.Services;

namespace Warp.Services
{
    public static class ResponseExtensionMethods
    {
        public static IResponse<T> ToSuccessfulResponse<T>(this T result)
        {
            return new ServiceResponse<T>(result);
        }
    }
}