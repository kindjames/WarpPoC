using FluentValidation;

namespace Warp.Core.Infrastructure.Validation
{
    public static class ValidationExtensions
    {
        public static IRuleBuilderOptions<T, TProperty> NotEmptyGuid<T, TProperty>(this IRuleBuilder<T, TProperty> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new NotEmptyGuidValidator());
        }
    }
}