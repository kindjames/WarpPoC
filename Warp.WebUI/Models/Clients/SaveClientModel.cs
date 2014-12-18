using System.ComponentModel.DataAnnotations;
using Warp.Core.Enum;
using Warp.Core.Infrastructure.Validation;
using Warp.WebUI.Models.Users;

namespace Warp.WebUI.Models.Clients
{
    public class SaveClientModel
    {
        [IdRequired]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public ClientStatus Status { get; set; }

        [Required]
        public UserViewModel AccountManager { get; set; }
    }
}