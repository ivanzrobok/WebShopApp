using FirstWebapplication.Data.Interfaces;
using FirstWebapplication.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebapplication.Data.Repository
{
    public class CarReposetory : IAllCars
    {
        private readonly AppDBContent appDBContent;
        public CarReposetory(AppDBContent addDBContent)//   /\
        {                                              //   || ->  коиструктор для інітіалізації
            this.appDBContent = addDBContent;

        }
        //получає дані з файла AddDBContent//
        public IEnumerable<Car> Cars
        { 
            get { return (appDBContent.Car).Include(c => c.Category); }
        }
        public IEnumerable<Car> GetFavCars => appDBContent.Car.Where(f => f.IsFavourite).Include(c=>c.Category);


        public Car GetObjectCar(int carID) => appDBContent.Car.FirstOrDefault(p => p.Id == carID);
 
    }
}
