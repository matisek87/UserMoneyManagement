using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserMoneyManagement.Interfaces;
using UserMoneyManagement.Requests;
using UserMoneyManagement.Response;

namespace UserMoneyManagement.Models
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserRepository(ApplicationDbContext context,
                                UserManager<ApplicationUser> userManager)
        {
            this._context = context;
            this._userManager = userManager;
        }
        public async Task<UserResponse> CreateUser(ApplicationUser user,string password)
        {
           
            var result = await _userManager.CreateAsync(user, password ?? "aA-" + Guid.NewGuid());
            var response = new UserResponse();
            if (result.Succeeded)
            {
                IdentityResult roleResult = await _userManager.AddToRoleAsync(user, "user");

                if (!roleResult.Succeeded)
                {
                    return response;
                }
              
                return response;
            }

            _context.Add(result);
            _context.SaveChanges();
            return response;
        }

        public Task GetUserById(string id)
        {
            throw new NotImplementedException();
        }

        public Task GetUserByName(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<UpdateUserResponse> UpdateUser(UpdateUserRequest user)
        {
            var response = new UpdateUserResponse();
            var foundUser = await _userManager.FindByIdAsync(user.UserId);
            if (foundUser == null)
            {
                response.EntityNotExist = false;
                return response;
            }

            response.Success = true;
            return response;
        }
    }
}
