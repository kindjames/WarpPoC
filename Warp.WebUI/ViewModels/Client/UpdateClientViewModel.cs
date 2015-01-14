using Warp.Core.Infrastructure.Validation;

namespace Warp.WebUI.ViewModels.Client
{
    public class UpdateClientViewModel : CreateClientViewModel
    {
        [IdRequired]
        public int Id { get; set; }
    }
}