using GameShop.ApplicationLogic.Abstractions;
using GameShop.ApplicationLogic.Model;
using GameShop.EFDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GameShop.EFDataAccess
{
    public class BillRepository : BaseRepository<Bill>, IBillRepository
    {
        public BillRepository(GameShopDBContext dBContext) : base(dBContext)
        {

        }


        public Bill GetBillByBillId(Guid orderId)
        {
            return dbContext.Bills.Where(a => a.Id == orderId).FirstOrDefault();
        }

        public IEnumerable<Bill> GetBillByUserId(Guid userId)
        {
            return dbContext.Bills.Where(a => a.UserId == userId).AsEnumerable();
        }

      
    }
}
