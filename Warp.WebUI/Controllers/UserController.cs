using System.Collections.Generic;
using System.Web.Mvc;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Services.UserService;
using Warp.WebUI.Infrastructure;
using Warp.WebUI.ViewModels.User;

namespace Warp.WebUI.Controllers
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