using AutoMapper;
using RecipeManager.Domain.Entities;
using RecipeManager.Domain.Interfaces;

namespace RecipeManager.Api.Services
{
    public class RecipeService : BaseService
    {
        private IRecipeRepository _recipeRepository { get; set; }

        public readonly IMapper _mapper;

        public RecipeService(IMapper mapper, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _mapper = mapper;
            _recipeRepository = UnitOfWork.RecipeRepository();
        }

        public async Task<Recipe> GetById(long id)
        {
            return await _recipeRepository.GetAsync(x=>x.Id==id);
        }

    }
}
