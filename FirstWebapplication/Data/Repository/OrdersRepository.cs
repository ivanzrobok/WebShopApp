using FirstWebapplication.Data.Interfaces;
using FirstWebapplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebapplication.Data.Repository
{
    //Класи які реалізують інтерфейси
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent _appDBContent;
        private readonly ShopCart _shopCart;
        public OrdersRepository(AppDBContent appDBContent, ShopCart shopCart)
        {
            _appDBContent = appDBContent;
            _shopCart = shopCart;
        }
        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            _appDBContent.Orders.Add(order);

            //Змінна для зберігання всіх товарів які купляє користовач
            var items = _shopCart.ListShopItems;

            foreach(var el in items)
            {
                var orderDetail = new OrderDetail();
                orderDetail.ID = el.Car.Id;
                orderDetail.OlderID = order.ID;
                orderDetail.Prise = el.Car.Prise;

                _appDBContent.OrderDetails.Add(orderDetail);
            }
            _appDBContent.SaveChanges();
        }
    }
}
