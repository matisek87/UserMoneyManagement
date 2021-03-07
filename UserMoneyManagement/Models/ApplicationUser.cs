using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserMoneyManagement.Enum;

namespace UserMoneyManagement.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset? DateOfBirth { get; set; }
        public Gender Gender { get; set; }

    }
}
