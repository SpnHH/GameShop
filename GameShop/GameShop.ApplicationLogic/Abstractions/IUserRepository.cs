using System;
using System.Collections.Generic;
using System.Text;
using GameShop.ApplicationLogic.Model;
namespace GameShop.ApplicationLogic.Abstractions
{
    public interface IUserRepository: IRepository<User>
    {
        User GetUserById(Guid userId);
    }
}
