﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UserMoneyManagement.Enum;

namespace UserMoneyManagement.Requests
{
    public class UpdateUserRequest
    {
        /// <summary>
        /// User Id.
        /// </summary>
        [Required]
        public string UserId { get; set; }

        /// <summary>
        /// User email address.
        /// </summary>
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// User first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// User last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// User date of birth.
        /// </summary>
        public DateTimeOffset DateOfBirth { get; set; }


        /// <summary>
        /// User gender.
        /// </summary>
        public Gender Gender { get; set; }
    }
}
