using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.ApplicationLogic.Model
{
    public class Rating
    {
        public Guid Id { get; set; }
        public Guid RatingId { get; set; }
        public User User { get; set; }
        public float Rate { get; set; }
    }
}
