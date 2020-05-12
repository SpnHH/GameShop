using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.ApplicationLogic.Model
{
    public class Comment
    {
        public Guid Id { get; set; }
        public Guid CommentId { get; set; }
        public User User { get; set; }
        public String Comm { get; set; }
    }
}
