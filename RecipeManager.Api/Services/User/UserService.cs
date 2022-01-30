using AutoMapper;
using RecipeManager.Api.DTOs;
using RecipeManager.Domain.Interfaces;

namespace RecipeManager.Api.Services
{
    public class UserService : BaseService
    {
        private IUserRepository _userRepository { get; set; }
        public readonly IMapper _mapper;

        public UserService(IMapper mapper, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _mapper = mapper;
            _userRepository = UnitOfWork.UserRepository();
        }

        public async Task<AddUserResponse> AddNewAsync(AddUserRequest model)
        {
            var user = _mapper.Map<Domain.Entities.User>(model);
            
            await _userRepository.AddAsync(user);
            await UnitOfWork.SaveChangesAsync();

            return _mapper.Map<AddUserResponse>(user);
        }


        //public async Task<List> SearchAsync(GetUserRequest request)
        //{
        //    var repository = UnitOfWork.AsyncRepository();
        //    var users = await repository
        //        .ListAsync(_ => _.UserName.Contains(request.Search));

        //    var userDTOs = users.Select(_ => new UserInfoDTO()
        //    {
        //        Address = _.Address,
        //        BirthDate = _.BirthDate,
        //        DepartmentId = _.DepartmentId,
        //        FirstName = _.FirstName,
        //        Id = _.Id,
        //        LastName = _.LastName,
        //        UserName = _.UserName
        //    })
        //    .ToList();

        //    return userDTOs;
        //}
    }
}
