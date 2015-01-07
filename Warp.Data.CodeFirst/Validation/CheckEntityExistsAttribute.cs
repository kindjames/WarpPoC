using System;
using System.ComponentModel.DataAnnotations;
using Warp.Core.Infrastructure.IoC;
using Warp.Core.Query;
using Warp.Data.Queries.General;

namespace Warp.Data.Validation
{
    public class CheckEntityExistsAttribute : ValidationAttribute
    {
        private readonly Type _entityType;

        [InjectDependency]
        public IQueryDispatcher QueryDispatcher { get; set; }

        public CheckEntityExistsAttribute(Type entityType)
        {
            _entityType = entityType;
        }

        public override bool IsValid(object value)
        {
            if (value == null) throw new ArgumentNullException("value");

            var queryType = typeof(CheckEntityExistsQuery<>)
                .MakeGenericType(_entityType);

            var query = (dynamic) Activator.CreateInstance(queryType);

            query.EntityId = Convert.ToInt32(value);

            if (QueryDispatcher.Execute(query))
            {
                // TODO: Get error message from Text Resource provider.
                ErrorMessage = "BLAH";

                return false;
            }

            return true;
        }
    }
}