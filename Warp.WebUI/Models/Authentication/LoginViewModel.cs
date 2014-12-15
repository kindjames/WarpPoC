using System.ComponentModel.DataAnnotations;
using Warp.Core.Attributes;

namespace Warp.WebUI.Models.Authentication
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }

        [PopulateWith(1)]
        public string UsernameLabelText { get; set; }

        [PopulateWith(2)]
        public string UsernamePlaceholderText { get; set; }

        [PopulateWith(3)]
        public string PasswordLabelText { get; set; }

        [PopulateWith(4)]
        public string PasswordPlaceholderText { get; set; }

        [PopulateWith(5)]
        public string RememberMeLabelText { get; set; }

        [PopulateWith(6)]
        public string LoginButtonText { get; set; }
    }
}