using FluentValidation;
using Warp.Core.Services.Dtos.Client;

namespace Warp.Core.Infrastructure.Validation.Dtos
{
    public class DtoBaseValidator : AbstractValidator<DtoBase>
    {
        public DtoBaseValidator()
        {
            RuleFor(m => m.Id)
                .NotEmptyGuid();
        }
    }
}