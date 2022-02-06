using AutoMapper;
using RecipeManager.Api.DTOs;

namespace RecipeManager.Api.DTOs
{
    public class IngredientProfile : Profile
    {
        public IngredientProfile()
        {
            CreateMap<StockIngredientDto, Domain.Entities.StockIngredient>().ReverseMap();
            CreateMap<IngredientCreateReq, Domain.Entities.Ingredient>()
                .ForMember(
                        dest => dest.StockIngredient, m => m.MapFrom(u => new StockIngredientDto() { Quantity = u.Quantity })
                ).ReverseMap();
        }
    }

}
