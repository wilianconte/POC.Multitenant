using Microsoft.AspNetCore.Mvc;
using POC.Multitenant.Domain.Commands.Requests;
using POC.Multitenant.Domain.Interfaces.Handlers;
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

        [HttpGet("")]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _userService.GetAllAsync();

            return Ok(result);
        }

        [HttpPost("")]
        public IActionResult Create
        (
            [FromServices] ICreateUserHandler handler,
            [FromBody] CreateUserRequest command,
            CancellationToken cancellationToken = default
        )
        {
            var response = handler.HandleAsync(command);

            return Ok(response);
        }
    }
}
