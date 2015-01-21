using System;
using FluentValidation;
using Warp.Core.Enum;
using Warp.Core.Infrastructure.Validation;
using Warp.WebUI.ViewModels.User;

namespace Warp.WebUI.ViewModels.Client
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