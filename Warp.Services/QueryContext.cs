using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.General;
using Warp.Core.Infrastructure.Validation;

namespace Warp.Services
{
    public class QueryContext<TResult> : IQueryContext<TResult>
    {
        private readonly IDispatcher _dispatcher;
        private readonly IValidationProvider _validationProvider;
        private readonly IObjectMapper _objectMapper;

        public QueryContext(IDispatcher dispatcher, IValidationProvider validationProvider, IObjectMapper objectMapper)
        {
            _dispatcher = dispatcher;
            _validationProvider = validationProvider;
            _objectMapper = objectMapper;
        }

        public IResponse<TResult> FromQuery<TEntity>(IQuery<TEntity> query)
        {
            // Validate POCO.
            var queryValidation = _validationProvider.Validate(query);

            if (!queryValidation.Successful)
            {
                return new GeneralResponse<TResult>(queryValidation);
            }

            // Dispatch Query to QueryHandler.
            var result = _dispatcher.Execute(query);

            // Map response to Dto.
            var resultDto = _objectMapper.MapTo<TResult>(result);

            return new GeneralResponse<TResult>(resultDto);
        }
    }
}