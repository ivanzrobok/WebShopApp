using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebapplication.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContent appDBContent;
        public ShopCart(AppDBContent addDBContent)//   /\
        {                                              //   || ->  коиструктор для інітіалізації
            this.appDBContent = addDBContent;
        }
        public string ShopCarID { get; set; }
        public List<ShopCarItem> ListShopItems { get; set; }
        
        public static ShopCart GetCar(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = service.GetService<AppDBContent>();

            string shopCarID = session.GetString("CarID") ?? Guid.NewGuid().ToString();
            //Guid створює нову корзину

            session.SetString("CarID", shopCarID);
            return new ShopCart(context) { ShopCarID = shopCarID };
        }
        public void AddToCart(Car car)
        {
            this.appDBContent.ShopItem.Add(new ShopCarItem
            {
                ShopCarID = ShopCarID,
                Car = car,
                Prise = car.Prise
            });
            appDBContent.SaveChanges();
        }
        public List<ShopCarItem> GetShopCarItems()
        {
            return appDBContent.ShopItem.Where(c => c.ShopCarID == ShopCarID).Include(s => s.Car).ToList();
        }
    }
}
