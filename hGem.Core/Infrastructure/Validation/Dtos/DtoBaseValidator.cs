using FluentValidation;
using hGem.Core.Services.Dtos.Client;

namespace hGem.Core.Infrastructure.Validation.Dtos
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