using GameShop.ApplicationLogic.Abstractions;
using GameShop.ApplicationLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameShop.EFDataAccess
{
    public class AdminRepository : BaseRepository<Admin>, IAdminRepository
    {
        public AdminRepository(GameShopDBContext dBContext) : base(dBContext)
        {

        }
        public Admin GetAdminByAdminId(Guid UserId)
        {
            return dbContext.Admins.Where(a => a.UserId == UserId).FirstOrDefault();
        }
        
    }
}
