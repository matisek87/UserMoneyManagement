﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserMoneyManagement.Response
{
    public class BaseResponse
    {
        public bool Success { get; set; }
        public bool EntityNotExist { get; set; }
        public bool EntityAlreadyExist { get; set; }
        public bool EntityAlreadyExists { get; set; }
        public bool EntityNotFound { get; set; }
        public bool Unauthorized { get; set; }
        



    }
}
