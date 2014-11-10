using FluentValidation;
using Warp.Data.Queries.Customers;

namespace Warp.Data.QueryValidators.Customers
{
    public sealed class GetCustomerQueryValidator : AbstractValidator<GetCustomerQuery>
    {
        public GetCustomerQueryValidator()
        {
            RuleFor(q => q.CustomerId)
                .GreaterThan(0);
        }
    }
}