using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameShop.ApplicationLogic.Model;
namespace GameShop.Models.Users
{
    public class UserGameViewModel
    {
        public IEnumerable<Game> Games { get; set; }
        public string category { get; set; }

    }
}
