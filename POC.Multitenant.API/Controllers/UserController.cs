using Microsoft.AspNetCore.Mvc;
using POC.Multitenant.Domain.Interfaces.Services;

namespace POC.Multitenant.API.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;

        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();

            return View();
        }
    }
}
