using System;
using System.Collections.Generic;
using System.Text;
using GameShop.ApplicationLogic.Model;
namespace GameShop.ApplicationLogic.Abstractions
{
    public interface IGameRepository : IRepository<Game>
    {
        Game GetGamebyId(Guid gameId);
        Game GetGameList();
        IEnumerable<Game> GetGameByCategory(string category);
    }
}
