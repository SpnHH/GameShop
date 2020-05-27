using System;
using System.Collections.Generic;
using System.Text;
using GameShop.ApplicationLogic.Model;
namespace GameShop.ApplicationLogic.Abstractions
{
    public interface IOrderRepository : IRepository<Order>
    {
        Order GetOrderByOrdeId(Guid orderId, User user);
        IEnumerable<Order> GetOrderByUserId(Guid userId);
        IEnumerable<Order> GetOrderByGameId(Guid gameId);
    }
}
