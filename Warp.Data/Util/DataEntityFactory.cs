//using System;
//using Warp.Core.Infrastructure;
//using Warp.Data.Entities;

//namespace Warp.Data.Util
//{
//    public sealed class DataEntityFactory : IDataEntityFactory
//    {
//        private readonly IDateTimeProvider _dateTimeProvider;

//        public DataEntityFactory(IDateTimeProvider dateTimeProvider)
//        {
//            _dateTimeProvider = dateTimeProvider;
//        }

//        public TEntity Build<TEntity>(Func<TEntity, TEntity> buildFunc = null)
//            where TEntity : EntityBase, new()
//        {
//            var now = _dateTimeProvider.UtcNow();

//            var entity = new TEntity()
//            {
//                DateCreated = now,
//                DateUpdated = now,
//            };

//            return buildFunc != null ? buildFunc(entity) : entity;
//        }
//    }
//}