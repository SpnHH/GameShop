using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.ApplicationLogic.Model
{
    public class Wishlist
    {
        public Guid Id { get; set; }
        public Guid GameId { get; set; }
        public Guid UserId { get; set; }
    }
}
