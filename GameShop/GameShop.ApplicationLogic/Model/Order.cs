using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.ApplicationLogic.Model
{
    public class Order
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public Guid GameId { get; set; }
        public DateTime Date { get; set; }
        public float TotalValue { get; set; }
       

    }
}
