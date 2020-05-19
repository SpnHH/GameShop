using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.Models.Users
{
    public class UserAddRatingViewModel
    {
        public Guid gameID { get; set; }
        public float Rate { get; set; }
    }
}
