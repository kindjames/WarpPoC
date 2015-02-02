using System.Collections.Generic;

namespace hGem.WebUI.ViewModels.User
{
    public class SelectUserViewModel : UserViewModel
    {
        public IEnumerable<UserViewModel> UserList { get; set; }
    }
}