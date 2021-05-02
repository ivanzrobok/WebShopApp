using FirstWebapplication.Data.Interfaces;
using FirstWebapplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebapplication.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategoris
        {
            get
            {
                return new List<Category> {
                    new Category{CategotyName = "Електромобілі ", Description = "сучасний вид транспорта"},
                    new Category{CategotyName = "Класичні автомобілі", Description = "Автомобілі з ДВС"}
                };
            }
        }
    }
}
