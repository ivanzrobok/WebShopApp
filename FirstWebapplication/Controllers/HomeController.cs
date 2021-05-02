using FirstWebapplication.Data.Interfaces;
using FirstWebapplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebapplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllCars _carRep;
        public HomeController(IAllCars carRep)
        {
            _carRep = carRep;
        }
        public ViewResult Index()///так само як називається метод, так і має називатися View
            ////так само як називається клас контроллера, так і має називатися папка
        {
            var homeCars = new HomeViewModel();
            homeCars.favCar = _carRep.GetFavCars;

            return View(homeCars);
        }
    }
}
