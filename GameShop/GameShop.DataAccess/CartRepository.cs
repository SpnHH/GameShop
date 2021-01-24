using GameShop.ApplicationLogic.Abstractions;
using GameShop.ApplicationLogic.Model;
using GameShop.EFDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GameShop.EFDataAccess
{
    public class CartRepository : BaseRepository<ShoppingCart>, ICartRepository
    {
        public CartRepository(GameShopDBContext dBContext) : base(dBContext)
        {

        }


        public ShoppingCart GetCartByCartId(Guid cartId)
        {
            return dbContext.ShoppingCart.Where(a => a.Id == cartId).FirstOrDefault();
        }

        public IEnumerable<ShoppingCart> GetCartByUserId(Guid userId)
        {
            return dbContext.ShoppingCart.Where(a => a.UserId == userId).AsEnumerable();
        }


    }
}
