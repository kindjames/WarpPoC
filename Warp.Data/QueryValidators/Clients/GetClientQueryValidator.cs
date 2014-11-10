using FluentValidation;
using Warp.Data.Queries.Clients;

namespace Warp.Data.QueryValidators.Clients
{
    public sealed class GetClientQueryValidator : AbstractValidator<GetClientQuery>
    {
        public GetClientQueryValidator()
        {
            RuleFor(q => q.ClientId)
                .NotEqual(0);
        }
    }
}