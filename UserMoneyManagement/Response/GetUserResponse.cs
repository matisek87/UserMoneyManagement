using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserMoneyManagement.Models;

namespace UserMoneyManagement.Response
{
    public class GetUserResponse : BaseResponse
    {
        public ApplicationUser User { get; set; }
    }
}
