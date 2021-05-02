using FirstWebapplication.Data.Interfaces;
using FirstWebapplication.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebapplication.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;
        public OrderController(IAllOrders appDBContent, ShopCart shopCart)
        {
            this.allOrders = appDBContent;
            this.shopCart = shopCart;
        }
        public IActionResult Checkout()//для дій,  дозволяє приймати дані
        {

            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)//для дій,  дозволяє приймати дані
        {
            shopCart.ListShopItems = shopCart.GetShopCarItems();

            if(shopCart.ListShopItems.Count == 0)
            {
                ModelState.AddModelError("","У вас мають бути товари в корзині");
            }

            if(ModelState.IsValid)
            {
                allOrders.CreateOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }
        public IActionResult Complite()
        {
            ViewBag.Message = "Заказа успішно оброблено";
            return View();
        }
    }
}
