﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameShop.ApplicationLogic.Abstractions;
using GameShop.ApplicationLogic.Exceptions;
using GameShop.ApplicationLogic.Model;

namespace GameShop.Models.Admins
{
    public class AdminEditGameView
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public string Category { get; set; }
    }
}
