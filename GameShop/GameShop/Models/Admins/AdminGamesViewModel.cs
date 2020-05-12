using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameShop.ApplicationLogic.Abstractions;
using GameShop.ApplicationLogic.Exceptions;
using GameShop.ApplicationLogic.Model;

namespace GameShop.Models.Admins
{
    public class AdminGamesViewModel
    {
        public Admin Admin { get; set; }
        public IEnumerable<Game> Games { get; set; }
    }
}
