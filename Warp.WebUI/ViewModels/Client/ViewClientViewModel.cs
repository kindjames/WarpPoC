using System.ComponentModel.DataAnnotations;
using Warp.Core.Enum;
using Warp.Core.Infrastructure.Validation;
using Warp.WebUI.ViewModels.User;

namespace Warp.WebUI.ViewModels.Client
{
    public class ViewClientViewModel
    {
        [IdRequired]
        public int Id { get; set; }

        [MinLength(1)]
        public string Name { get; set; }

        [MinLength(1)]
        public string Code { get; set; }

        public ClientStatus Status { get; set; }

        public UserViewModel AccountManager { get; set; }
    }
}