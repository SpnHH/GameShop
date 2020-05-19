using System;
using System.Collections.Generic;
using System.Text;
using GameShop.ApplicationLogic.Model;
namespace GameShop.ApplicationLogic.Abstractions
{
    public interface IRatingRepository : IRepository<Rating>
    {
        Rating GetRating(Guid ratingId);
    }
}
