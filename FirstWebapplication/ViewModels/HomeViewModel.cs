using FirstWebapplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebapplication.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Car> favCar { get; set; }
    }
}
