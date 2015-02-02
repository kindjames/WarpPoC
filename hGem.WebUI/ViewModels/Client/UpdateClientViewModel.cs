using System;
using FluentValidation;
using hGem.Core.Infrastructure.Validation;

namespace hGem.WebUI.ViewModels.Client
{
    public class UpdateClientViewModel : CreateClientViewModel
    {
        public Guid Id { get; set; }
    }

    public class UpdateClientViewModelValidator : AbstractValidator<UpdateClientViewModel>
    {
        public UpdateClientViewModelValidator()
        {
            RuleFor(vm => vm.Id)
                .NotEmptyGuid();
        }
    }
}