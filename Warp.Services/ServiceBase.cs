using System;
using System.Collections.Generic;
using Warp.Core.Services;

namespace Warp.Services
{
    public abstract class ServiceBase
    {
        protected IResponse Success()
        {
            return new ServiceResponse();
        }
        protected IResponse Failed(IEnumerable<String> errorMessages)
        {
            return new ServiceResponse(errorMessages);
        }

        protected IResponse<TResult> Success<TResult>(TResult result)
        {
            return new ServiceResponse<TResult>(result);
        }
    }
}