using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameShop.ApplicationLogic.Model;

namespace GameShop.Models.Users
{
    public class AddOrderModelView
    {
        public Guid Id { get; set; }
        public Guid GameId { get; set; }

        public Guid UserId { get; set; }

    }
}
