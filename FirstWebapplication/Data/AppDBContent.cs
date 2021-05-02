using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstWebapplication.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstWebapplication.Data
{
    public class AppDBContent : DbContext//для роботи з базами даних
    {
        //тут реєструємо таблиці
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) { }

        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShopCarItem> ShopItem { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }

  
}
