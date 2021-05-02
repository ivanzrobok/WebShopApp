using FirstWebapplication.Data.Interfaces;
using FirstWebapplication.Data.Models;
using FirstWebapplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FirstWebapplication.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllCars _carRep;
        private readonly ShopCart _shopCart;
        public ShopCartController(IAllCars carRep, ShopCart shopCart)
        {
            _carRep = carRep;
            _shopCart = shopCart;
        }
        public ViewResult Index()
        {
            var Items = _shopCart.GetShopCarItems();
            _shopCart.ListShopItems = Items;

            var obj = new ShopCarViewModel { shopCart = _shopCart };
            return View(obj);
        }
        public RedirectToActionResult AddToCart(int id)
        {
            var item = _carRep.Cars.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
