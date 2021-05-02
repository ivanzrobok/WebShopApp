using FirstWebapplication.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebapplication.Data
{
    public class DBObject
    {
        public static void Initial(AppDBContent content)
        {

            if (!content.Categories.Any())
            {
                content.AddRange(CategoriesData.Select(c => c.Value));
            }
            if(!content.Car.Any())
            {
                content.AddRange
                (
                    new Car
                    {
                        Name = "Tesla Model S",
                        ShortDesc = "",
                        LongDesc = "Гарний та швидкий електромобіль",
                        Img = "/img/tesla.jpg",
                        Prise = 45000,
                        IsFavourite = true,
                        Available = true /*в наявності*/,
                        Category = CategoriesData["Електромобілі"]
                    },
                    new Car
                    {
                        Name = "Ford Fiesta",
                        ShortDesc = "",
                        LongDesc = "Зручний автомобіль для міської їзди",
                        Img = "/img/ford.jpg",
                        Prise = 11000,
                        IsFavourite = false,
                        Available = true,
                        Category = CategoriesData["Класичні автомобілі"]
                    },
                    new Car
                    {
                        Name = "BMW M3"
                        ,
                        ShortDesc = ""
                        ,
                        LongDesc = "Зручний автомобіль для міської їзди"
                        ,
                        Img = "/img/BMW.jpg"
                        ,
                        Prise = 65000
                        ,
                        IsFavourite = true
                        ,
                        Available = true
                        ,
                        Category = CategoriesData["Класичні автомобілі"]
                    },
                    new Car
                    {
                        Name = "Mercedes C class"
                        ,
                        ShortDesc = "Зручний автомобіль"
                        ,
                        LongDesc = "Зручний автомобіль для міської їзди"
                        ,
                        Img = "/img/mercedes.jpg"
                        ,
                        Prise = 40000
                        ,
                        IsFavourite = false
                        ,
                        Available = false
                        ,
                        Category = CategoriesData["Класичні автомобілі"]
                    },
                    new Car
                    {
                            Name = "Nissan Leaf",
                             ShortDesc = "Безшумний і економний",
                             LongDesc = "Зручний автомобіль для міської їзди",
                             Img = "/img/nissan.jpg",
                             Prise = 14000,
                             IsFavourite = true,
                             Available = true ,
                             Category = CategoriesData["Електромобілі"]
                    }
                );
                content.SaveChanges();
            }
        }
        private static Dictionary<string, Category> categoryData;
        public static Dictionary<string, Category> CategoriesData
        {
            get
            {
                if(categoryData == null)
                {
                    var list = new Category[]
                    {
                        new Category{CategotyName = "Електромобілі", Description = "сучасний вид транспорта"},
                        new Category{CategotyName = "Класичні автомобілі", Description = "Автомобілі з ДВС"}
                    };
                    categoryData = new Dictionary<string, Category>();

                    //заповнюємо
                    foreach(var el in list)
                        categoryData.Add(el.CategotyName, el);
                }
                return categoryData;

            }
        }
            

    }
}
