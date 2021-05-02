using FirstWebapplication.Data.Interfaces;
using FirstWebapplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebapplication.Data.Mocks
{
    public class MockCars : ICarsCategory
    {
        private readonly ICarsCategory _carsCategory = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car {
                        Name = "Tesla Model S"
                        ,ShortDesc = ""
                        , LongDesc = "Гарний та швидкий електромобіль"
                        ,Img = "/img/tesla.jpg"
                        , Prise = 45000
                        ,IsFavourite = true
                        , Available = true /*в наявності*/
                        ,Category = _carsCategory.AllCategoris.First()
                    },
                    new Car
                    {
                        Name = "Ford Fiesta"
                        ,ShortDesc = ""
                        ,LongDesc = "Зручний автомобіль для міської їзди"
                        ,Img ="/img/ford.jpg"
                        ,Prise = 11000
                        ,IsFavourite = false
                        ,Available = true
                        ,Category = _carsCategory.AllCategoris.Last()
                    },
                    new Car
                    {
                        Name = "BMW M3"
                        ,ShortDesc = ""
                        ,LongDesc = "Зручний автомобіль для міської їзди"
                        ,Img = "/img/BMW.jpg"
                        ,Prise = 65000
                        ,IsFavourite = true
                        ,Available = true
                        ,Category = _carsCategory.AllCategoris.Last()
                    },
                    new Car
                    {
                        Name = "Mercedes C class"
                        ,ShortDesc = "Зручний автомобіль"
                        ,LongDesc = "Зручний автомобіль для міської їзди"
                        ,Img = "/img/mercedes.jpg"
                        ,Prise = 40000
                        ,IsFavourite = false
                        ,Available = false
                        ,Category = _carsCategory.AllCategoris.Last()
                    },
                    new Car
                    {
                        Name ="Nissan Leaf"
                        ,ShortDesc = "Безшумний і економний"
                        ,LongDesc = "Зручний автомобіль для міської їзди"
                        ,Img = "/img/nissan.jpg"
                        ,Prise = 14000
                        ,IsFavourite = true
                        ,Available  = true
                        ,Category = _carsCategory.AllCategoris.First()
                    }
                };
            }
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public IEnumerable<Category> AllCategoris => throw new NotImplementedException();

        public Car GetObjectCar(int carID)
        {
            throw new NotImplementedException();
        }
    }
}