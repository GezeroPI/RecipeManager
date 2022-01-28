using Microsoft.AspNetCore.Mvc;
using RecipeManager.Api.DTOs.Users;
using RecipeManager.Api.Services;

namespace RecipeManager.Api.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        private readonly UserService _service;
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger
            , UserService service)
        {
            _service = service;
            _logger = logger;

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }

        //[HttpPost]
        //public async Task<IActionResult> Add([FromBody] AddUserRequest request)
        //{
        //    var users = await _service.AddNewAsync(request);
        //    return Ok(users);
        //}

    }
}
