using System;
using System.Collections.Generic;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.IoC;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Services.Dtos.Client;

namespace Warp.Core.Operations
{
    public interface ICommand
    {
        IOperationResult Execute();
    }

    public interface IQuery<out TResult>
    {
        IOperationResult<TResult> Execute();
    }

    public interface IOperationResult
    {
        bool Success { get; }
        IEnumerable<string> Messages { get; }
    }

    public interface IOperationResult<out T> : IOperationResult
    {
        T Result { get; }
    }

    public interface IQueryExecutionContext<out TQuery, out TResult>
        where TQuery : class, IQuery<TResult>
    {
        IQueryExecutionContext<TQuery, TResult> WithParameters(Action<TQuery> operation);
        IQueryExecutionContext<TQuery, TResult> FromValidDto<TDto>(TDto dto) where TDto : DtoBase;
        IOperationResult<TResult> ValidateAndExecute();
    }

    public class QueryExecutionContext<TQuery, TResult> : IQueryExecutionContext<TQuery, TResult>
        where TQuery : class, IQuery<TResult>
    {
        private readonly IObjectMapper _objectMapper;
        private readonly IValidator _validator;
        private readonly TQuery _query;

        public QueryExecutionContext(IServiceLocator serviceLocator, IObjectMapper objectMapper, IValidator validator)
        {
            _objectMapper = objectMapper;
            _validator = validator;
            _query = serviceLocator.TryResolve<TQuery>();
        }

        public IQueryExecutionContext<TQuery, TResult> WithParameters(Action<TQuery> query)
        {
            query(_query);
            return this;
        }

        public IQueryExecutionContext<TQuery, TResult> FromValidDto<TDto>(TDto dto) where TDto : DtoBase
        {
            _validator.Validate(dto);
            _objectMapper.Map(dto, _query);
            return this;
        }

        public IOperationResult<TResult> ValidateAndExecute()
        {
            _validator.Validate(_query);
            return _query.Execute();
        }
    }

    public interface ICommandExecutionContext<out TCommand>
        where TCommand : ICommand
    {
        ICommandExecutionContext<TCommand> WithParameters(Action<TCommand> operation);
        ICommandExecutionContext<TCommand> FromValidDto<TDto>(TDto dto) where TDto : DtoBase;
        IOperationResult ValidateAndExecute();
    }

    public class CommandExecutionContext<TCommand> : ICommandExecutionContext<TCommand>
        where TCommand : class, ICommand
    {
        private readonly IObjectMapper _objectMapper;
        private readonly IValidator _validator;
        private readonly TCommand _command;

        public CommandExecutionContext(IServiceLocator serviceLocator, IObjectMapper objectMapper, IValidator validator)
        {
            _objectMapper = objectMapper;
            _validator = validator;
            _command = serviceLocator.TryResolve<TCommand>();
        }

        public ICommandExecutionContext<TCommand> WithParameters(Action<TCommand> command)
        {
            command(_command);
            return this;
        }

        public ICommandExecutionContext<TCommand> FromValidDto<TDto>(TDto dto) where TDto : DtoBase
        {
            _validator.Validate(dto);
            _objectMapper.Map(dto, _command);
            return this;
        }

        public IOperationResult ValidateAndExecute()
        {
            _validator.Validate(_command);
            return _command.Execute();
        }
    }

    public interface IOperationFactory
    {
        IQueryExecutionContext<TQuery, TResult> Build<TQuery, TResult>()
            where TQuery : class, IQuery<TResult>;

        ICommandExecutionContext<TCommand> Build<TCommand>()
            where TCommand : class, ICommand;
    }

    public class OperationFactory : IOperationFactory
    {
        private readonly IValidator _validator;
        private readonly IServiceLocator _serviceLocator;
        private readonly IObjectMapper _objectMapper;

        public OperationFactory(IValidator validator, IServiceLocator serviceLocator, IObjectMapper objectMapper)
        {
            _validator = validator;
            _serviceLocator = serviceLocator;
            _objectMapper = objectMapper;
        }

        public IQueryExecutionContext<TQuery, TResult> Build<TQuery, TResult>()
            where TQuery : class, IQuery<TResult>
        {
            return new QueryExecutionContext<TQuery, TResult>(
                _serviceLocator, _objectMapper, _validator);
        }

        public ICommandExecutionContext<TCommand> Build<TCommand>()
            where TCommand : class, ICommand
        {
            return new CommandExecutionContext<TCommand>(
                _serviceLocator, _objectMapper, _validator);
        }
    }
}