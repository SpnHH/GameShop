using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.ApplicationLogic.Model
{
    public class ShoppingCart
    {
        public Guid Id { get; set; }
        public Guid GameId { get; set; }
        public Guid UserId { get; set; }
        public int Quantity { get; set; }
    }
}
