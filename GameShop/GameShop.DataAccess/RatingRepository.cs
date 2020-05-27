using GameShop.ApplicationLogic.Abstractions;
using GameShop.ApplicationLogic.Model;
using GameShop.EFDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GameShop.EFDataAccess
{
    public class RatingRepository : BaseRepository<Rating>, IRatingRepository
    {
        public RatingRepository(GameShopDBContext dBContext) : base(dBContext)
        {

        }

        public Rating GetRating(Guid ratingId)
        {
            return dbContext.Ratings.Where(a => a.Id == ratingId).FirstOrDefault();
        }

        public IEnumerable<Rating> GetRatingByGameId(Guid gameId)
        {
            return dbContext.Ratings.Where(a => a.GameId == gameId).AsEnumerable();
        }
    }
}
