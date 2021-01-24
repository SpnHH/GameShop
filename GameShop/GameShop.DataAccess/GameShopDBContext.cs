using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using GameShop.ApplicationLogic.Model;
namespace GameShop.EFDataAccess 
{
    public class GameShopDBContext : DbContext
    {
        public GameShopDBContext(DbContextOptions<GameShopDBContext> options) : base(options)
        {

        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }

        public DbSet<Bill> Bills { get; set; }
    }
}

