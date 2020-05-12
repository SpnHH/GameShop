using GameShop.ApplicationLogic.Abstractions;
using GameShop.ApplicationLogic.Model;
using GameShop.EFDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GameShop.EFDataAccess
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(GameShopDBContext dBContext) : base(dBContext)
        {

        }

        public User GetUserById(Guid userId)
        {
            return dbContext.Users.Where(a => a.Id == userId).FirstOrDefault();
        }
    }
}

