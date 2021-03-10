using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UserMoneyManagement.Enum;

namespace UserMoneyManagement.Requests
{
    public class CreateUserRequest
    {

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required]
        [EmailAddress]
        public string Email { get; set; }


        public string FirstName { get; set; }

        public string LastName { get; set; }


        public DateTimeOffset DateOfBirth { get; set; }


        public Gender Gender { get; set; }
    }
}
