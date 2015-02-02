using System;
using FluentValidation;
using hGem.Core.Domain.Enum;
using hGem.Core.Infrastructure.Validation;
using hGem.WebUI.ViewModels.User;

namespace hGem.WebUI.ViewModels.Client
{
    public class ViewClientViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public ClientStatus Status { get; set; }
        public UserViewModel AccountManager { get; set; }
    }

    public class ViewClientViewModelValidator : AbstractValidator<ViewClientViewModel>
    {
        public ViewClientViewModelValidator()
        {
            RuleFor(vm => vm.Id).NotEmptyGuid();
            RuleFor(vm => vm.Name).Length(1, 300);
            RuleFor(vm => vm.Code).Length(1, 100);
        }
    }
}