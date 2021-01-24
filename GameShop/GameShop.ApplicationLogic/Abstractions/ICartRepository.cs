using System;
using System.Collections.Generic;
using System.Text;
using GameShop.ApplicationLogic.Model;
namespace GameShop.ApplicationLogic.Abstractions
{
    public interface ICartRepository : IRepository<ShoppingCart>
    {
        ShoppingCart GetCartByCartId(Guid cartId);
        IEnumerable<ShoppingCart> GetCartByUserId(Guid userId);
        
    }
}
