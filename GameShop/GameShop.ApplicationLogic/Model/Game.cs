using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.ApplicationLogic.Model
{
    public class Game
    {
        public Guid Id { get; set; }
        public Guid GameId { get; set; }
        public Admin Admin { get; set; }
        public ICollection<Comment> Comment { get; set; }
        public ICollection<Rating> Rating { get; set; }
        public String Name { get; set; }
        public float Price { get; set; }
        public String Description { get; set; }
    }
}
