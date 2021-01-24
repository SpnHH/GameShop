using GameShop.ApplicationLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.Models.Users
{
    public class ViewCart
    {
        public IEnumerable<ShoppingCart> Orders { get; set; }
        public IEnumerable<Game> Games { get; set; }
    }
}
