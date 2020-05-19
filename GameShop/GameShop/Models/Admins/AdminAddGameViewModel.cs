using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameShop.ApplicationLogic.Abstractions;
using GameShop.ApplicationLogic.Exceptions;
using GameShop.ApplicationLogic.Model;
using System.Web;
using Microsoft.AspNetCore.Http;
using System.ComponentModel;

namespace GameShop.Models.Admins
{
    public class AdminAddGameViewModel
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
    }
}
