﻿using RecipeManager.Api.DTOs.Users;
using RecipeManager.Domain.Entities;
using RecipeManager.Domain.Interfaces;

namespace RecipeManager.Api.Services
{
    public class UserService : BaseService
    {
        public UserService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        //public async Task AddNewAsync(AddUserRequest model)
        //{
        //    // You can you some mapping tools as such as AutoMapper
        //    var user = new User(model.UserName
        //        , model.FirstName
        //        , model.LastName
        //        , model.Email);

        //    var repository = UnitOfWork.AsyncRepository();
        //    await repository.AddAsync(user);
        //    await UnitOfWork.SaveChangesAsync();

        //    var response = new AddUserResponse()
        //    {
        //        Id = user.Id,
        //        UserName = user.UserName
        //    };

        //    return response;
        //}


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