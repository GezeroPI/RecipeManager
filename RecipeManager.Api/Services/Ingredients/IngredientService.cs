using AutoMapper;
using RecipeManager.Api.DTOs;
using RecipeManager.Domain.Interfaces;

namespace RecipeManager.Api.Services
{
    public class IngredientService : BaseService
    {
        private IIngredientRepository _ingredientRepository { get; set; }

        public readonly IMapper _mapper;

        public IngredientService(IMapper mapper, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _mapper = mapper;
            _ingredientRepository = UnitOfWork.IngredientRepository();
        }

        public async Task<IngredientCreateReq> AddNewAsync(IngredientCreateReq model)
        {
            var ingredient = _mapper.Map<Domain.Entities.Ingredient>(model);

            await _ingredientRepository.AddAsync(ingredient);
            await UnitOfWork.SaveChangesAsync();

            return _mapper.Map<IngredientCreateReq>(ingredient);
        }
    }
}
