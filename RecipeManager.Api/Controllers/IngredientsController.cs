using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeManager.Api.DTOs;
using RecipeManager.Api.Services;

namespace RecipeManager.Api.Controllers
{
    [ApiController]
    [Route("Ingredients")]
    public class IngredientsController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;
        private readonly IngredientService _service;
        public IngredientsController(ILogger<UserController> logger, IngredientService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] IngredientCreateReq ingredientCreateReq)
        {
            try
            {
                return Ok(await _service.AddNewAsync(ingredientCreateReq));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
