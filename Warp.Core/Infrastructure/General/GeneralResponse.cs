using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Warp.Core.Infrastructure.General
{
    public class GeneralResponse : IResponse
    {
        public bool Successful { private set; get; }
        public IReadOnlyList<string> Errors { private set; get; }

        public GeneralResponse(bool successful = true)
        {
            Successful = successful;
        }

        public GeneralResponse(IEnumerable<string> errorMessages, bool successful = true)
            : this (successful)
        {
            Errors = new ReadOnlyCollection<string>(errorMessages.ToList());
        }
    }

    public class GeneralResponse<T> : GeneralResponse, IResponse<T>
    {
        public T Result { private set; get; }

        public GeneralResponse(IResponse response)
            : base(response.Errors, response.Successful)
        {
        }

        public GeneralResponse(T result, bool successful = true)
            : base(successful)
        {
            Result = result;
        }

        public GeneralResponse(IEnumerable<string> errorMessages)
            : base(errorMessages)
        {
        }
    }
}