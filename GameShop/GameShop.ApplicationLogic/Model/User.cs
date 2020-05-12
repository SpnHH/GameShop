using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.ApplicationLogic.Model
{
    public class User
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public String UserName { get; set; }
        public String Passord { get; set; }
        public String Email { get; set; }
    }
}
