using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserMoneyManagement.Requests
{
    public class ChangePasswordRequest
    {
        public string UserId { get; set; }

        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
