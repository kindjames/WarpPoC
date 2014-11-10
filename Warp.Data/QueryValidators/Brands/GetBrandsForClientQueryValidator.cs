using FluentValidation;
using Warp.Data.Queries.Brands;

namespace Warp.Data.QueryValidators.Brands
{
    public sealed class GetBrandsForClientQueryValidator : AbstractValidator<GetBrandsForClientQuery>
    {
        public GetBrandsForClientQueryValidator()
        {
            RuleFor(q => q.ClientId)
                .GreaterThan(0);
        }
    }
}