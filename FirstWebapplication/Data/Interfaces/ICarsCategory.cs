using FirstWebapplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebapplication.Data.Interfaces
{
    public interface ICarsCategory
    {
        public IEnumerable<Category> AllCategoris { get; }
    }
}
