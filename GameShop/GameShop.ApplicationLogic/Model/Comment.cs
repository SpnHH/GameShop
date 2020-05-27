using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.ApplicationLogic.Model
{
    public class Comment
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public String Comm { get; set; }
        public Guid GameId { get; set; }
        public string Username { get; set; }
    }
}
