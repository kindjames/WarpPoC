using System;
using Warp.Core.Infrastructure.Validation;

namespace Warp.WebUI.ViewModels.Client
{
    public class UpdateClientViewModel : CreateClientViewModel
    {
        [IdRequired]
        public Guid Id { get; set; }
    }
}