using Microsoft.AspNetCore.Mvc;
using RecipeManager.Api.Services;

namespace RecipeManager.Api.Controllers
{
    [ApiController]
    [Route("recipes")]
    public class RecipeController : ControllerBase
    {
        private readonly RecipeService _service;
        private readonly ILogger<UserController> _logger;

        public RecipeController(ILogger<UserController> logger
            , RecipeService service)
        {
            _service = service;
            _logger = logger;

        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            try
            {
                throw new Exception("Some Err");

                return Ok(_service.GetById(id));
            }
            catch (Exception ex)
            {
                _logger.LogError("Test");
                return BadRequest(ex.Message);
            }
        }
    }
}
