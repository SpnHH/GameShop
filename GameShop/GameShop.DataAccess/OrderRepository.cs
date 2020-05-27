using GameShop.ApplicationLogic.Abstractions;
using GameShop.ApplicationLogic.Model;
using GameShop.EFDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GameShop.EFDataAccess
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(GameShopDBContext dBContext) : base(dBContext)
        {

        }

        public IEnumerable<Order> GetOrderByGameId(Guid gameId)
        {
            return dbContext.Orders.Where(a => a.GameId == gameId).AsEnumerable();
        }

        public Order GetOrderByOrdeId(Guid orderId, User user)
        {
            return dbContext.Orders.Where(a => a.Id == orderId).FirstOrDefault();
        }

        public IEnumerable<Order> GetOrderByUserId(Guid userId)
        {
            return dbContext.Orders.Where(a => a.User.Id == userId).AsEnumerable();
        }

      
    }
}
