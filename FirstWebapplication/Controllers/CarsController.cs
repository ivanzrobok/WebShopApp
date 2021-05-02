using FirstWebapplication.Data.Interfaces;
using FirstWebapplication.Data.Models;
using FirstWebapplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;


namespace FirstWebapplication.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategory;

        public CarsController(IAllCars allCars, ICarsCategory carsCategory)
        {
            _allCars = allCars;
            _allCategory = carsCategory;
        }
        [Route("Cars/List")]
        [Route("Cars/List/{category}")]//тут теж має співпадати
        public ViewResult List(string category)//параметрмає співпадати з пошуковим шаблоном Url
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";

            if (string.IsNullOrEmpty(category))
                cars = _allCars.Cars.OrderBy(i => i.Id);
            else
            {
                if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.CategotyName.Equals("Електромобілі")).OrderBy(i => i.Id);
                    currCategory = "Електромобілі";
                }
                else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.CategotyName.Equals("Класичні автомобілі")).OrderBy(i => i.Id);
                    currCategory = "Класичні автомобілі";
                }
               
            }

            var carobj = new CarsListViewModel();
            carobj.AllCars = cars;
            carobj.CurrentCategory = currCategory;
            ViewBag.Title = "Сторінка з автомобілями";

            return View(carobj);
        }

    }
}
