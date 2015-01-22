using System;
using System.Collections.Generic;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.General;
using Warp.Core.Infrastructure.Validation;

namespace Warp.Services
{
    public abstract class ServiceBase
    {
        private readonly IDispatcher _dispatcher;
        private readonly IObjectMapper _objectMapper;
        private readonly IValidationProvider _validationProvider;

        protected ServiceBase(IDispatcher dispatcher, IObjectMapper objectMapper, IValidationProvider validationProvider)
        {
            _dispatcher = dispatcher;
            _objectMapper = objectMapper;
            _validationProvider = validationProvider;
        }

        protected IResponse Success()
        {
            return new GeneralResponse();
        }

        protected IResponse Failed(IEnumerable<String> errorMessages)
        {
            return new GeneralResponse(errorMessages);
        }

        protected IResponse<TResult> Success<TResult>(TResult result)
        {
            return new GeneralResponse<TResult>(result);
        }

        protected IQueryContext<TResult> ResponseOf<TResult>()
        {
            return new QueryContext<TResult>(
                _dispatcher, _validationProvider, _objectMapper);
        }

        protected IQueryContext<IEnumerable<TResult>> ResponseOfMany<TResult>()
        {
            return new QueryContext<IEnumerable<TResult>>(
                _dispatcher, _validationProvider, _objectMapper);
        }

        protected ICommandContext<TCommand> ResponseFromCommand<TCommand>()
            where TCommand : class, ICommand
        {
            return new CommandContext<TCommand>(
                _dispatcher, _validationProvider, _objectMapper);
        }
    }
}