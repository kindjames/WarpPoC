using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Warp.Core.Services;

namespace Warp.Core.Infrastructure.Validation
{
    public class ValidationResponse : IResponse
    {
        public ValidationResponse()
        {
            Successful = true;
        }

        public ValidationResponse(IEnumerable<string> messages)
        {
            Successful = false;
            Messages = new ReadOnlyCollection<string>(messages.ToList());
        }

        public bool Successful { get; private set; }
        public IReadOnlyList<string> Messages { get; private set; }
    }

    public class ValidationResponse<T> : ValidationResponse, IResponse<T>
    {
        public ValidationResponse()
        {
        }

        public ValidationResponse(IEnumerable<string> messages)
            : base (messages)
        {
        }

        public T Result
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}