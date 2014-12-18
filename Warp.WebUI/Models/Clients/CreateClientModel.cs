using System.ComponentModel.DataAnnotations;
using Warp.Core.Enum;
using Warp.WebUI.Models.Users;

namespace Warp.WebUI.Models.Clients
{
    public class CreateClientModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public ClientStatus Status { get; set; }

        [Required]
        public UserViewModel AccountManager { get; set; }

        public string NameLabelText { get; set; }

        public string CodeLabelText { get; set; }

        public string StatusLabelText { get; set; }
    }
}