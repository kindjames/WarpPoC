using System;
using System.Collections.Generic;
using System.Linq;
using Warp.Core.Data;
using Warp.Core.Operations;
using Warp.Data.Context;

namespace Warp.Data.Operations.Query
{
    public static class ServiceExtentions
    {
        public static IOperationResult<T> ToResponse<T>(this T t)
        {
            return new OperationResult<T>(t);
        }
    }

    public class OperationResult<TResult> : OperationResult, IOperationResult<TResult>
    {
        public TResult Result { get; protected set; }

        public OperationResult(TResult result)
        {
            Result = result;
        }

        public OperationResult(IEnumerable<string> messages)
            : base(messages)
        {
        }
    }

    public class OperationResult : IOperationResult
    {
        public bool Success { get; private set; }
        public IEnumerable<string> Messages { get; private set; }

        public OperationResult()
        {
            Success = true;
        }
        
        public OperationResult(IEnumerable<string> messages)
        {
            Success = false;
            Messages = messages;
        }
    }

    public interface ICheckEntityExistsQuery : IQuery<bool>
    {
        Guid EntityId { get; set; }
    }

    public interface IGetEntityQuery<out TEntity> : IQuery<TEntity>
        where TEntity : EntityBase
    {
        Guid EntityId { get; set; }
    }

    public class CheckEntityExistsQuery2<TEntity> : ICheckEntityExistsQuery
        where TEntity : EntityBase
    {
        private readonly IDomainDbContext _dbContext;

        public Guid EntityId { get; set; }

        public CheckEntityExistsQuery2(IDomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IOperationResult<bool> Execute()
        {
            return _dbContext.Set<TEntity>()
                .Any(e => e.Id == EntityId)
                .ToResponse();
        }
    }

    public class GetEntityQuery<TEntity> : IGetEntityQuery<TEntity>
        where TEntity : EntityBase
    {
        private readonly IDomainDbContext _dbContext;

        public Guid EntityId { get; set; }

        public GetEntityQuery(IDomainDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IOperationResult<TEntity> Execute()
        {
            return _dbContext.Set<TEntity>()
                .Single(e => e.Id == EntityId)
                .ToResponse();
        }
    }
}