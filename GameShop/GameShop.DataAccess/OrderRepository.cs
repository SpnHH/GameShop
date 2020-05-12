using GameShop.ApplicationLogic.Abstractions;
using GameShop.ApplicationLogic.Model;
using GameShop.EFDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GameShop.EFDataAccess
{
    public class OrderRepository : BaseRepository<Comment>, IOrderRepository
    {
        public OrderRepository(GameShopDBContext dBContext) : base(dBContext)
        {

        }

        public Order Add(Order itemToAdd)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Order itemToDelete)
        {
            throw new NotImplementedException();
        }

        public Order GetOrderByOrdeId(Guid orderId, User user)
        {
            return dbContext.Orders.Where(a => a.Id == orderId).FirstOrDefault();
        }

        public Order Update(Order itemToUpdate)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Order> IRepository<Order>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
