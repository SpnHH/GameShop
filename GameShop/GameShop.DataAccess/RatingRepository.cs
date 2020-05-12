using GameShop.ApplicationLogic.Abstractions;
using GameShop.ApplicationLogic.Model;
using GameShop.EFDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GameShop.EFDataAccess
{
    public class RatingRepository : BaseRepository<Comment>, IRatingRepository
    {
        public RatingRepository(GameShopDBContext dBContext) : base(dBContext)
        {

        }

        public Rating Add(Rating itemToAdd)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Rating itemToDelete)
        {
            throw new NotImplementedException();
        }

        public Rating GetRating(Guid ratingId, Game game, User user)
        {
            return dbContext.Ratings.Where(a => a.Id == ratingId).FirstOrDefault();
        }

        public Rating Update(Rating itemToUpdate)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Rating> IRepository<Rating>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
