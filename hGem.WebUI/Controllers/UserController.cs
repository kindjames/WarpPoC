using System.Collections.Generic;
using System.Web.Mvc;
using hGem.Core.Infrastructure.AutoMapper;
using hGem.Core.Services.UserService;
using hGem.WebUI.Infrastructure;
using hGem.WebUI.ViewModels.User;

namespace hGem.WebUI.Controllers
{
    [Authorize]
    [RoutePrefix("user")]
    [PopulateTextResourcesOnModel]
    public partial class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IObjectMapper _objectMapper;

        public UserController(IUserService userService, IObjectMapper objectMapper)
        {
            _userService = userService;
            _objectMapper = objectMapper;
        }

        [HttpGet]
        public virtual ActionResult List(IEnumerable<UserViewModel> users)
        {
            return PartialView(users);
        }

        [HttpGet]
        public virtual ActionResult SelectUser(SelectUserViewModel model)
        {
            var users = _userService.GetUsers();

            model.UserList = _objectMapper.MapToMany<UserViewModel>(users);

            return PartialView(model);
        }
    }
}