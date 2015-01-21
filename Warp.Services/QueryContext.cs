using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.General;
using Warp.Core.Infrastructure.Validation;

namespace Warp.Services
{
    public class QueryContext<TResult> : IQueryContext<TResult>
    {
        private readonly IDispatcher _dispatcher;
        private readonly IValidator _validator;
        private readonly IObjectMapper _objectMapper;

        public QueryContext(IDispatcher dispatcher, IValidator validator, IObjectMapper objectMapper)
        {
            _dispatcher = dispatcher;
            _validator = validator;
            _objectMapper = objectMapper;
        }

        public IResponse<TResult> From<TEntity>(IQuery<TEntity> query)
        {
            // Validate POCO.
            var queryValidation = _validator.Validate(query);

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