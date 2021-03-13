using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserMoneyManagement.Requests;
using UserMoneyManagement.ServiceResponse;

namespace UserMoneyManagement.Interfaces
{
    interface IUserService
    {
        Task<InstertUserServiceResponse> CreateUser(CreateUserRequest request);

        Task<UpdateUserServiceResponse> UpdateUser(UpdateUserRequest request);

        
        Task<GetUserServiceResponse> GetUser(string userId);
    }
}
