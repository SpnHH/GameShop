﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.Models.Users
{
    public class UserAddCommentViewModel
    {
        public Guid gameID { get; set; }
        public String Comm { get; set; }

    }
}
