using GameShop.ApplicationLogic.Abstractions;
using GameShop.ApplicationLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameShop.EFDataAccess
{
    public class GameRepository : BaseRepository<Game>, IGameRepository
    {
        public GameRepository(GameShopDBContext dBContext) : base(dBContext)
        {

        }
        public Game GetGamebyId(Guid gameId)
        {
            return dbContext.Games.Where(a => a.Id == gameId).FirstOrDefault();
        }

        public Game GetGameList()
        {
            throw new NotImplementedException();
        }
    }
}
