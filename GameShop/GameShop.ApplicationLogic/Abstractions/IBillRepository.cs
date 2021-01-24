using System;
using System.Collections.Generic;
using System.Text;
using GameShop.ApplicationLogic.Model;
namespace GameShop.ApplicationLogic.Abstractions
{
    public interface IBillRepository : IRepository<Bill>
    {
        Bill GetBillByBillId(Guid orderId);
        IEnumerable<Bill> GetBillByUserId(Guid billId);
    }
}
