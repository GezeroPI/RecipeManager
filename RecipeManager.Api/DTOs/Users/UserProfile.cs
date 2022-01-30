using AutoMapper;
using RecipeManager.Api.DTOs;

namespace RecipeManager.Api.DTOs
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<AddUserRequest, Domain.Entities.User>().ReverseMap();
            CreateMap<AddUserResponse, Domain.Entities.User>().ReverseMap();
        }
    }

}
