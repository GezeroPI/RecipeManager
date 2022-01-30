using RecipeManager.Domain.Entities;
using RecipeManager.Domain.Interfaces;

namespace RecipeManager.Api.Services
{
    public class RecipeService : BaseService
    {
        private IRecipeRepository _recipeRepository { get; set; }
        public RecipeService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _recipeRepository = UnitOfWork.RecipeRepository();
        }

        public async Task<Recipe> GetById(long id)
        {
            return await _recipeRepository.GetAsync(x=>x.Id==id);
        }

    }
}
