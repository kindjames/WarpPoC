using System.ComponentModel.DataAnnotations;
using Warp.Core.Attributes;

namespace Warp.WebUI.ViewModels.Authentication
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }

        [PopulateWith("UsernameLabelText")]
        public string UsernameLabelText { get; set; }

        [PopulateWith("UsernamePlaceholderText")]
        public string UsernamePlaceholderText { get; set; }

        [PopulateWith("PasswordLabelText")]
        public string PasswordLabelText { get; set; }

        [PopulateWith("PasswordPlaceholderText")]
        public string PasswordPlaceholderText { get; set; }

        [PopulateWith("RememberMeLabelText")]
        public string RememberMeLabelText { get; set; }

        [PopulateWith("LoginButtonText")]
        public string LoginButtonText { get; set; }
    }
}