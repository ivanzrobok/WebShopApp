
using FirstWebapplication.Data.Interfaces;
using FirstWebapplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebapplication.Data.Repository
{
    public class CategoryReposetory : ICarsCategory
    {
        private readonly AppDBContent appDBContent;
        public CategoryReposetory(AppDBContent addDBContent)//   /\
        {                                              //   || ->  коиструктор для інітіалізації
            this.appDBContent = addDBContent;

        }
        public IEnumerable<Category> AllCategoris => appDBContent.Categories;

        
    }
}
