using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Warp.Core.Operations;
using Warp.Core.Services;

namespace Warp.Services
{
    //public static class ServiceExtensions
    //{
    //    public static IResponse<TDto> ToDtoResponse<TDto, TResult>(this IOperationResult<TResult> result)
    //    {
            
    //    }
    //}

    public class ServiceResponse : IResponse
    {
        public bool Successful { private set; get; }
        public IReadOnlyList<string> Messages { private set; get; }

        public ServiceResponse(bool successful = true)
        {
            Successful = successful;
        }

        public ServiceResponse(IEnumerable<string> errorMessages)
        {
            Successful = false;
            Messages = new ReadOnlyCollection<string>(errorMessages.ToList());
        }
    }

    public class ServiceResponse<T> : ServiceResponse, IResponse<T>
    {
        public T Result { private set; get; }

        public ServiceResponse(T result, bool successful = true)
            : base(successful)
        {
            Result = result;
        }

        public ServiceResponse(IEnumerable<string> errorMessages)
            : base(errorMessages)
        {
        }
    }
}