using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserMoneyManagement.Models;

namespace UserMoneyManagement.Controllers
{

    
    [ApiController]
    [Route("identity/api/users")]
    public class UserController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<UserController> _logger;

        public UserController(UserManager<ApplicationUser> userManager,
                                SignInManager<ApplicationUser> signInManager,
                                ILogger<UserController> logger)
            
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._logger = logger;
        }
     
       


    }
}
