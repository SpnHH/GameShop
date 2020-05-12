using GameShop.ApplicationLogic.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.ApplicationLogic.Abstractions
{
    public interface IAdminRepository : IRepository<Admin>
    {
        Admin GetAdminByAdminId(Guid UserId);
    }
}
