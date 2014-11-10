using FluentValidation;
using Warp.Data.Queries.Customers;

namespace Warp.Data.QueryValidators.Customers
{
    public sealed class GetCustomerNameQueryValidator : AbstractValidator<GetCustomerNameQuery>
    {
        public GetCustomerNameQueryValidator()
        {
            RuleFor(q => q.CustomerId)
                .GreaterThan(0);
        }
    }
}