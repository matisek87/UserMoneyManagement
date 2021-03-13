using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserMoneyManagement.Models;
using UserMoneyManagement.Requests;
using UserMoneyManagement.Response;

namespace UserMoneyManagement.Interfaces
{
    interface IUserRepository
    {
        Task<UserResponse> CreateUser(ApplicationUser user, string password);
        Task<UpdateUserResponse> UpdateUser(UpdateUserRequest request);
        Task<GetUserResponse> GetUserById(string id);
        Task<GetUserResponse> GetUserByName(string username);

    }
}
