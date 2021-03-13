using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        [Route("create")]
        public async Task<UserResponse> CreateUser(ApplicationUser user,string password)
        {
           
            var result = await _userManager.CreateAsync(user, password ?? "aA-" + Guid.NewGuid());
            var response = new UserResponse();
            if (result.Succeeded)
            {
                IdentityResult roleResult = await _userManager.AddToRoleAsync(user, "user");

                if (!roleResult.Succeeded)
                {
                    response.Errors = response.Errors.ToList();
                    return response;
                }

                response.Success = true;
                return response;
            }

            _context.Add(result);
            _context.SaveChanges();
            return response;
        }

        public async Task<GetUserResponse> GetUserById(string id)
        {
            //AsNoTracking  EF vrati data, no netrackuje zmeny, ak sa nejake vykonaju zabudne na to ... najma ak len na citanie dat
            var user = await _userManager.Users.AsNoTracking().FirstOrDefaultAsync(user => user.Id == id);

            return new GetUserResponse()
            {
                Success = (user != null),
                EntityNotFound = (user == null),
                User = user
            };
        }

        public async Task<GetUserResponse> GetUserByName(string username)
        {
            var user = await _userManager.FindByNameAsync(username);
            return new GetUserResponse
            {
                Success = (user != null),
                User = user
            };
        }

        public async Task<UpdateUserResponse> UpdateUser(UpdateUserRequest user)
        {
            var response = new UpdateUserResponse();
            var foundUser = await _userManager.FindByIdAsync(user.UserId);
            if (foundUser == null)
            {
                response.EntityNotExist = true;
                return response;
            }

            //context.entry vyberie usera podla Id z DB z requestu a ulozi ho pod foundUser .currentValue vezme aktualne udaje z foundUsera a .setValues(user) do aktualnych hodnot setne hodnoty co prisli zvonku - UpdateUserRequest
            _context.Entry(foundUser).CurrentValues.SetValues(user);
            IdentityResult result = await _userManager.UpdateAsync(foundUser);
            if (result.Succeeded)
            {
                response.Success = true;
            }
            else
            {
                response.Errors = result.Errors.ToList();
            }

            return response;
        }
    }
}
