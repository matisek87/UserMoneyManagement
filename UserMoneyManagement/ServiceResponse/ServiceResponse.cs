using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserMoneyManagement.Response;

namespace UserMoneyManagement.ServiceResponse
{
    public class ServiceResponse
    {
        public List<MessageCode> MessageCodes { get; set; }

        public object Value { get; set; }

        public bool HasValue { get; set; }

    }
}
