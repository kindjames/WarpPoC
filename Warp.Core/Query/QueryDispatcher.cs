using System.Diagnostics;
using FluentValidation;
using FluentValidation.Results;
using Warp.Core.Exceptions;
using Warp.Core.Infrastructure.IoC;

namespace Warp.Core.Query
{
    public class QueryDispatcher : IQueryDispatcher
    {
        private readonly IServiceLocator _serviceLocator;

        public QueryDispatcher(IServiceLocator serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

        public TResult Execute<TResult>(IQuery<TResult> query)
        {
            Validate(query);

            var handlerType = typeof(IQueryHandler<,>)
                .MakeGenericType(query.GetType(), typeof(TResult));

            var handler = _serviceLocator.TryResolve(handlerType);
            
            if (handler == null)
            {
                throw new QueryHandlerNotFoundException<TResult>(query);
            }

            return ((dynamic)handler).Execute((dynamic) query);
        }

        private void Validate<TResult>(IQuery<TResult> query)
        {
            var validatorType = typeof(AbstractValidator<>)
                .MakeGenericType(query.GetType());

            var validator = _serviceLocator.TryResolve(validatorType);

            if (validator != null)
            {
                var validationResult = (ValidationResult) ((dynamic)validator).Validate((dynamic)query);

                if (!validationResult.IsValid)
                {
                    throw new ValidationFailedException(query, validationResult.Errors);
                }
            }
            else if (Debugger.IsAttached)
            {
                throw new ValidatorNotFoundForEntityException(query.GetType());
            }
        }
    }
}