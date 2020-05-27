using GameShop.ApplicationLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.Models.Users
{
    public class UserMainGameViewModel
    {
        public Game Game { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public float Rating { get; set; }
    }
}
