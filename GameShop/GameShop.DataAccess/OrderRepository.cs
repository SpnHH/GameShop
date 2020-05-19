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

       

        public Order GetOrderByOrdeId(Guid orderId, User user)
        {
            return dbContext.Orders.Where(a => a.Id == orderId).FirstOrDefault();
        }


        IEnumerable<Order> IRepository<Order>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
