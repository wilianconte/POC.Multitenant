using Microsoft.AspNetCore.Mvc;
using POC.Multitenant.Domain.Interfaces.Services;

namespace POC.Multitenant.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            var result = _userService.GetAll();

            return Ok(result);
        }
    }
}
